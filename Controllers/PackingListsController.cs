using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcoVenture.Models;
using EcoVenture.Data;

namespace EcoVenture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackingListsController : ControllerBase
    {
        private readonly EcoVentureDbContext _context;

        public PackingListsController(EcoVentureDbContext context)
        {
            _context = context;
        }

        // GET: api/PackingLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PackingList>>> GetPackingLists()
        {
            return await _context.PackingLists.ToListAsync();
        }

        // GET: api/PackingLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PackingList>> GetPackingList(int id)
        {
            var packingList = await _context.PackingLists.FindAsync(id);

            if (packingList == null)
            {
                return NotFound();
            }

            return packingList;
        }

        // PUT: api/PackingLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPackingList(int id, PackingList packingList)
        {
            if (id != packingList.PackingListID)
            {
                return BadRequest();
            }

            // Validate foreign keys
            if (!UserExists(packingList.UserID) || 
                !LocationExists(packingList.LocationID) || 
                !SeasonExists(packingList.SeasonID) || 
                !WeatherExists(packingList.WeatherID))
            {
                return BadRequest("Invalid UserID, LocationID, SeasonID, or WeatherID.");
            }

            _context.Entry(packingList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PackingListExists(id))
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

        // POST: api/PackingLists
        [HttpPost]
        public async Task<ActionResult<PackingList>> PostPackingList(PackingList packingList)
        {
            // Validate foreign keys
            if (!UserExists(packingList.UserID) || 
                !LocationExists(packingList.LocationID) || 
                !SeasonExists(packingList.SeasonID) || 
                !WeatherExists(packingList.WeatherID))
            {
                return BadRequest("Invalid UserID, LocationID, SeasonID, or WeatherID.");
            }

            _context.PackingLists.Add(packingList);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPackingList), new { id = packingList.PackingListID }, packingList);
        }

        // DELETE: api/PackingLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PackingList>> DeletePackingList(int id)
        {
            var packingList = await _context.PackingLists.FindAsync(id);
            if (packingList == null)
            {
                return NotFound();
            }

            _context.PackingLists.Remove(packingList);
            await _context.SaveChangesAsync();

            return packingList;
        }

        private bool PackingListExists(int id)
        {
            return _context.PackingLists.Any(e => e.PackingListID == id);
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserID == id);
        }

        private bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.LocationID == id);
        }

        private bool SeasonExists(int id)
        {
            return _context.Seasons.Any(e => e.SeasonID == id);
        }

        private bool WeatherExists(int id)
        {
            return _context.WeatherConditions.Any(e => e.WeatherID == id);
        }
    }
}
