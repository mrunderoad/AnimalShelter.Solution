using System.ComponentModel.DataAnnotations;

namespace Shelter.Models
{
  public class Monkey
  {
    public int MonkeyId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    [Range(0, 30, ErrorMessage = "Age must be between 0 and 100.")]
    public int Age { get; set; }
    [Required]
    [StringLength(10)]
    public string Gender { get; set; }
  }
}