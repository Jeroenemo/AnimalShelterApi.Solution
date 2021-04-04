using System;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
                .HasData(
                    new Animal { AnimalId = 1, Name = "Attila", Age = 3, Gender = "Male", Admitted = DateTime.Now, SpeciesId = 1 },
                    new Animal { AnimalId = 2, Name = "RZA", Age = 10, Gender = "Male", Admitted = DateTime.Now, SpeciesId = 1 },
                    new Animal { AnimalId = 3, Name = "Maple", Age = 1, Gender = "Female", Admitted = DateTime.Now, SpeciesId = 2 },
                    new Animal { AnimalId = 4, Name = "Beatrix", Age = 2, Gender = "Female", Admitted = DateTime.Now, SpeciesId = 2 },
                    new Animal { AnimalId = 5, Name = "Petunia",  Age = 12, Gender = "Female", Admitted = DateTime.Now, SpeciesId = 3 }
                );
            builder.Entity<Species>()
                .HasData(
                    new Species { SpeciesId = 1, Type = "Cat" },
                    new Species { SpeciesId = 2, Type = "Chicken" },
                    new Species { SpeciesId = 3, Type = "Donkey" }
                );
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }
    }
}