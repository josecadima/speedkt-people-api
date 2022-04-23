using System;

namespace speedkt.imagehandler
{
    public interface IImageStore
    {
        void UploadAvatar(Guid id, string imageData);
    }
}
