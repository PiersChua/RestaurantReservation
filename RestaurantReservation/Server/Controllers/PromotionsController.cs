using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Server.IRepository;
using RestaurantReservation.Shared.Domain;
using RestaurantReservation.Server.Data;


namespace PromotionPromotion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public PromotionsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/promotions
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Promotion>>> GetPromotions()
        public async Task<IActionResult> GetPromotions()
        {
            //Refactored
            //return await _context.Promotions.ToListAsync();
            var promotions = await _unitOfWork.Promotions.GetAll();
            return Ok(promotions);
        }

        // GET: api/Promotions/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Promotion>> GetPromotion(int id)
        public async Task<IActionResult> GetPromotion(int id)
        {
            //Refactored    
            //var promotion = await _context.Promotions.FindAsync(id);
            var promotion = await _unitOfWork.Promotions.Get(q => q.Id == id);

            if (promotion == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(promotion);
        }

        // PUT: api/Promotions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromotion(int id, Promotion promotion)
        {
            if (id != promotion.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(promotion).State = EntityState.Modified;
            _unitOfWork.Promotions.Update(promotion);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!PromotionExists(id))
                if (!await PromotionExists(id))
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

        // POST: api/Promotions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Promotion>> PostPromotion(Promotion promotion)
        {
            //Refactored
            //_context.Promotions.Add(promotion);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Promotions.Insert(promotion);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPromotion", new { id = promotion.Id }, promotion);
        }

        // DELETE: api/Promotions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromotion(int id)
        {
            //Refactored
            //var promotion = await _context.Promotions.FindAsync(id);
            var promotion = await _unitOfWork.Promotions.Get(q => q.Id == id);
            if (promotion == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Promotions.Remove(promotion);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Promotions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PromotionExists(int id)
        {
            //Refactored
            //return (_context.Promotions?.Any(e => e.Id == id)).GetValueOrDefault();
            var promotion = await _unitOfWork.Promotions.Get(q => q.Id == id);
            return promotion != null;
        }
    }
}
