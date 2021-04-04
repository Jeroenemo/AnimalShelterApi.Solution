using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public class Species
    {
        public Species()
        {
            this.Animals = new HashSet<Animal>();
        }
        public int SpeciesId { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}