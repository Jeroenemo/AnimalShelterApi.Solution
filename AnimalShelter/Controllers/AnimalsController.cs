using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]  
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animal>>> Get(string gender, string name)
        {
            var query = _db.Animals.AsQueryable();

            if (gender != null)
            {
                query = query.Where(entry => entry.Gender == gender);
            }

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            return await query.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            var animal = await _db.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            return animal;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            _db.Entry(animal).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Animal>> Post(Animal animal, string type)
        {
            var thisSpecies = _db.Species.Include(entry => entry.Animals).FirstOrDefault(entry => entry.Type == type);

            if (thisSpecies != null)
            {
                animal.Admitted = DateTime.Now;
                animal.SpeciesId = thisSpecies.SpeciesId;
                thisSpecies.Animals.Add(animal);
                _db.Species.Update(thisSpecies);
                await _db.SaveChangesAsync();
            }
            else
            {
                return BadRequest();
            }

            return CreatedAtAction("Post", new { id = animal.SpeciesId }, thisSpecies);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animal = await _db.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }

            _db.Animals.Remove(animal);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool AnimalExists(int id)
        {
            return _db.Animals.Any(entry => entry.AnimalId == id);
        }
    }
}