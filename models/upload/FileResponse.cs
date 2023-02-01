using System.ComponentModel.DataAnnotations;

namespace baseNetApi.models.upload;

public class FileResponse: BaseResponse
{
    [Required]
    public string pathFile { get; set; } = "";
}