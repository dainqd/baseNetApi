using baseNetApi.models.upload;

namespace baseNetApi.service.interfaces;

public interface IFileService
{
    Task SavePostImageAsync(PostFileRequest postRequest);
    Task<FileResponse> CreatePostAsync(PostFileRequest postRequest);
}