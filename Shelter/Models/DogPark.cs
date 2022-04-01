using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Shelter.Models
{
  public class DogPark
  {
    public DogPark()
    {
      this.Dogs = new HashSet<Dog>(); 
    }
    public int DogParkId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<Dog> Dogs { get; set; }
  }
}