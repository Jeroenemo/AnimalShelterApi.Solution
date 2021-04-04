using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Models;
using System;

namespace AnimalShelter.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]  
    [Route("api/[controller]")]
    public class SpeciesController : ControllerBase
    {
        private readonly AnimalShelterContext _db;

        public SpeciesController(AnimalShelterContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Species>>> Get(string type)
        {
            var query = _db.Species.Include(entry => entry.Animals).AsQueryable();

            if (type != null)
            {
                query = query.Where(entry => entry.Type == type);
            }
            return await query.ToListAsync();
        }

        [HttpGet("{type}")]
        public async Task<ActionResult<Species>> GetSpecies(string type)
        {
            var thisId = _db.Species.FirstOrDefault(entry => entry.Type == type).SpeciesId;
            var Species = await _db.Species.FindAsync(thisId);

            if (Species == null)
            {
                return NotFound();
            }

            return Species;
        }

        [HttpPost]
        public async Task<ActionResult<Species>> Post(Species species)
        {
            if ((_db.Species.FirstOrDefault(entry => entry.Type == species.Type)) != null)
            {
                return BadRequest();
            }
        else 
        {
            _db.Species.Add(species);
            await _db.SaveChangesAsync();
        }
        return CreatedAtAction("Post", new { id = species.SpeciesId }, species);
        }
    }
}