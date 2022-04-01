using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shelter.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    [StringLength(50)]
    public string Breed { get; set; }
    [Required]
    [Range(0, 30, ErrorMessage = "Age must be between 0 and 30.")]
    public int Age { get; set; }
    [Required]
    [StringLength(10)]
    public string Gender { get; set; }
  }
}