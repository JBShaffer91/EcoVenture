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
    public class ProductRecommendationsController : ControllerBase
    {
        private readonly EcoVentureDbContext _context;

        public ProductRecommendationsController(EcoVentureDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductRecommendations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductRecommendation>>> GetProductRecommendations()
        {
            return await _context.ProductRecommendations.ToListAsync();
        }

        // GET: api/ProductRecommendations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductRecommendation>> GetProductRecommendation(int id)
        {
            var recommendation = await _context.ProductRecommendations.FindAsync(id);

            if (recommendation == null)
            {
                return NotFound();
            }

            return recommendation;
        }

        // PUT: api/ProductRecommendations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductRecommendation(int id, ProductRecommendation recommendation)
        {
            if (id != recommendation.RecommendationID)
            {
                return BadRequest();
            }

            if (!ProductExists(recommendation.ProductID) || !PackingListExists(recommendation.PackingListID))
            {
                return NotFound();
            }

            _context.Entry(recommendation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductRecommendationExists(id))
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

        // POST: api/ProductRecommendations
        [HttpPost]
        public async Task<ActionResult<ProductRecommendation>> PostProductRecommendation(ProductRecommendation recommendation)
        {
            if (!ProductExists(recommendation.ProductID) || !PackingListExists(recommendation.PackingListID))
            {
                return BadRequest();
            }

            _context.ProductRecommendations.Add(recommendation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductRecommendation), new { id = recommendation.RecommendationID }, recommendation);
        }

        // DELETE: api/ProductRecommendations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductRecommendation>> DeleteProductRecommendation(int id)
        {
            var recommendation = await _context.ProductRecommendations.FindAsync(id);
            if (recommendation == null)
            {
                return NotFound();
            }

            _context.ProductRecommendations.Remove(recommendation);
            await _context.SaveChangesAsync();

            return recommendation;
        }

        private bool ProductRecommendationExists(int id)
        {
            return _context.ProductRecommendations.Any(e => e.RecommendationID == id);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }

        private bool PackingListExists(int id)
        {
            return _context.PackingLists.Any(e => e.PackingListID == id);
        }
    }
}
