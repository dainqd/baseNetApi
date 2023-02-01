using System.ComponentModel.DataAnnotations;

namespace baseNetApi.models.upload;

public class PostFileRequest
{
    [Required]
    public string pathFile { get; set; } = "";
}