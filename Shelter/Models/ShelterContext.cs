using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    public ShelterContext(DbContextOptions<ShelterContext> options) : base(options)
    {
    }

    public DbSet<Cat> Cats { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Sr.Waffles", Breed = "Red One", Age = 2, Gender = "Male" },
          new Cat { CatId = 2, Name = "Senior Meowmeow", Breed = "Pink One", Age = 5, Gender = "Male" },
          new Cat { CatId = 3, Name = "Frank the Tank", Breed = "Black Cat", Age = 12, Gender = "Male" },
          new Cat { CatId = 4, Name = "Henry", Breed = "White Cat", Age = 7, Gender = "Male" },
          new Cat { CatId = 5, Name = "Cat", Breed = "I dont know cat breeds", Age = 4, Gender = "Female" },
          new Cat { CatId = 6, Name = "Epicat", Breed = "CodeCat", Age = 5, Gender = "Male" },
          new Cat { CatId = 7, Name = "Bill", Breed = "FatCat", Age = 100, Gender = "Male" },
          new Cat { CatId = 8, Name = "Phil", Breed = "KittyCat", Age = 1, Gender = "Male" }
        );
    }
  }
}