using System;

namespace speedkt.imagehandler
{
    public interface IImageStore
    {
        Task UploadAvatar(Guid id, string filePath);
    }
}
