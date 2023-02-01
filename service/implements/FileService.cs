using baseNetApi.models.upload;
using baseNetApi.service.interfaces;

namespace baseNetApi.service.user;

public class FileService : IFileService
{
        public Task SavePostImageAsync(PostFileRequest postRequest)
        {
            throw new NotImplementedException();
        }

        public Task<FileResponse> CreatePostAsync(PostFileRequest postRequest)
        {
            throw new NotImplementedException();
        }
}