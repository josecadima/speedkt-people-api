using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;

namespace speedkt.imagehandler
{
    public class ImageStore : IImageStore
    {
        private string bucket;
        private RegionEndpoint region;
        private string validExt;
        private long maxAvatarSizeKB = 100;

        public ImageStore(IConfiguration config)
        {
            bucket = config["AvatarStore:Bucket"];
            region = RegionEndpoint.USEast1;
            validExt = config["AvatarStore:ValidExt"];
            long.TryParse(config["AvatarStore:MaxSizeKB"], out maxAvatarSizeKB);
        }

        public void UploadAvatar(Guid id, string imageData)
        {
            try
            {
                Stream imageStream;
                if (!IsValidImageData(imageData, out imageStream)) 
                    return;

                var key = $"{id.ToString()}.{validExt}";

                using (var client = new AmazonS3Client(region))
                {
                    var request = new PutObjectRequest
                    {
                        BucketName = bucket,
                        Key = key,
                        InputStream = imageStream,
                        ContentType = "text/plain"
                    };

                    client.PutObjectAsync(request).Wait();
                }
            }
            catch (Exception e)
            {
                //TODO add logs
            }
        }

        private bool IsValidImageData(string imageData, out Stream imageStream)
        {
            imageStream = new MemoryStream();
            var spl = imageData.Split('/')[1];
            var imageFormat = spl.Split(';')[0];

            if (imageFormat.ToLower() != validExt)
                return false;

            var bytes = Convert.FromBase64String(imageData.Split(',')[1]);
            
            imageStream = new MemoryStream(bytes);

            if (imageStream.Length > maxAvatarSizeKB * 1024)
                return false;

            return true;
        }
    }
}