using System.ComponentModel.DataAnnotations;

namespace LetsTest.Api.DTOs
{
  public class CourseDto
  {
    public int Id { get; set; }
    [Required] public int Name { get; set; }
  }
}