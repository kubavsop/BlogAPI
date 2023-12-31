using System.ComponentModel.DataAnnotations;

namespace Blog.API.Controllers.Dto.Requests;

public class CreateTagDto
{
    [Required]
    [MinLength(1)]
    [MaxLength(100)]
    public string Name { get; set; }
}