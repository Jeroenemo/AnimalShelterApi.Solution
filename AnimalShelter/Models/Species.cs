using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public class Species
    {
        public Species()
        {
            this.Animals = new HashSet<Animal>();
        }
        public int AnimalId { get; set; }
        public string Species { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}