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
                    new Animal { AnimalId = 1, Name = "Attila", Species = "Cat", Age = 3, Gender = "Male", Admitted = DateTime.Now },
                    new Animal { AnimalId = 2, Name = "RZA", Species = "Cat", Age = 10, Gender = "Male", Admitted = DateTime.Now },
                    new Animal { AnimalId = 3, Name = "Maple", Species = "Chicken", Age = 1, Gender = "Female", Admitted = DateTime.Now },
                    new Animal { AnimalId = 4, Name = "Beatrix", Species = "Chicken", Age = 2, Gender = "Female", Admitted = DateTime.Now },
                    new Animal { AnimalId = 5, Name = "Petunia", Species = "Donkey", Age = 12, Gender = "Female", Admitted = DateTime.Now }
                );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}