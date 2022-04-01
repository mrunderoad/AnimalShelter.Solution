using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    public ShelterContext(DbContextOptions<ShelterContext> options) : base(options)
    {
    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Monkey> Monkeys { get; set; }

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

      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Pickles", Breed = "Hot Dog", Age = 4, Gender = "Male" },
          new Dog { DogId = 2, Name = "Jeremy", Breed = "Cold Dog", Age = 5, Gender = "Male" },
          new Dog { DogId = 3, Name = "Fred", Breed = "Long Haired Pug", Age = 10, Gender = "Male" },
          new Dog { DogId = 4, Name = "Stacy", Breed = "Got it goin on", Age = 16, Gender = "Mom" },
          new Dog { DogId = 5, Name = "Dog", Breed = "Dog", Age = 4, Gender = "Dog" },
          new Dog { DogId = 6, Name = "Baguette", Breed = "Bread dog", Age = 4, Gender = "Bread" }
        );

      builder.Entity<Monkey>()
        .HasData(
          new Monkey { MonkeyId = 1, Name = "Koko", Age = 30, Gender = "Female" },
          new Monkey { MonkeyId = 2, Name = "Bilbo Baggins", Age = 45, Gender = "Male" },
          new Monkey { MonkeyId = 3, Name = "Connor McMonkey", Age = 33, Gender = "Male" },
          new Monkey { MonkeyId = 4, Name = "Izzy Booboo", Age = 22, Gender = "Female"}
        );
    }
  }
}