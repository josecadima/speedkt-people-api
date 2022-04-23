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
        private string validAvatarExt;
        private long maxAvatarSizeKB = 100;

        public ImageStore(IConfiguration config)
        {
            bucket = config["AvatarStore:Bucket"];
            region = RegionEndpoint.USEast1;
            validAvatarExt = config["AvatarStore:ValidExt"];
            long.TryParse(config["AvatarStore:MaxSizeKB"], out maxAvatarSizeKB);
        }

        public async Task UploadAvatar(Guid id, string filePath)
        {
            try
            {
                if (!IsFileValid(filePath))
                    return;

                var key = id.ToString() + new FileInfo(filePath).Extension;

                using (var client = new AmazonS3Client(region))
                {
                    var request = new PutObjectRequest
                    {
                        BucketName = bucket,
                        Key = key,
                        FilePath = filePath,
                        ContentType = "text/plain"
                    };

                    await client.PutObjectAsync(request);
                }
            }
            catch (Exception e)
            {
                //TODO add logs
            }
        }

        private bool IsFileValid(string filePath)
        {
            if (!File.Exists(filePath))
                return false;

            var fileInfo = new FileInfo(filePath);

            if (fileInfo.Extension.ToLower() != validAvatarExt)
                return false;

            if (fileInfo.Length > maxAvatarSizeKB * 1024)
                return false;

            return true;
        }
    }
}