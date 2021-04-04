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
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class SpeciesController : ControllerBase
    {
        private readonly AnimalShelterContext _db;

        public SpeciesController(AnimalShelterContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Species>>> Get()
        {
            var query = _db.Species.Include(entry => entry.Animals).AsQueryable();

            return await query.ToListAsync();
        }

        [HttpGet("{type}")]
        public async Task<ActionResult<IEnumerable<Species>>> GetSpecies(string type)
        {
            var query = _db.Species.Include(entry => entry.Animals).AsQueryable();

            if (type != null)
            {
                query = query.Where(entry => entry.Type == type);
            }
            else
            {
                return NotFound();
            }
            return await query.ToListAsync();
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