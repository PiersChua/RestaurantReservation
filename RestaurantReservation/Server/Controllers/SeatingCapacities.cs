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


namespace RestaurantReservation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatingCapacitiesController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public SeatingCapacitiesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/SeatingCapacities
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<SeatingCapacitie>>> GetSeatingCapacities()
        public async Task<IActionResult> GetSeatingCapacities()
        {
            //Refactored
            //return await _context.SeatingCapacities.ToListAsync();
            var SeatingCapacities = await _unitOfWork.SeatingCapacities.GetAll();
            return Ok(SeatingCapacities);
        }

        // GET: api/SeatingCapacities/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<SeatingCapacitie>> GetSeatingCapacitie(int id)
        public async Task<IActionResult> GetSeatingCapacitie(int id)
        {
            //Refactored    
            //var SeatingCapacitie = await _context.SeatingCapacities.FindAsync(id);
            var SeatingCapacitie = await _unitOfWork.SeatingCapacities.Get(q => q.Id == id);

            if (SeatingCapacitie == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(SeatingCapacitie);
        }

        // PUT: api/SeatingCapacities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeatingCapacitie(int id, SeatingCapacity SeatingCapacitie)
        {
            if (id != SeatingCapacitie.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(SeatingCapacitie).State = EntityState.Modified;
            _unitOfWork.SeatingCapacities.Update(SeatingCapacitie);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!SeatingCapacitieExists(id))
                if (!await SeatingCapacitieExists(id))
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

        // POST: api/SeatingCapacities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SeatingCapacity>> PostSeatingCapacitie(SeatingCapacity SeatingCapacitie)
        {
            //Refactored
            //_context.SeatingCapacities.Add(SeatingCapacitie);
            //await _context.SaveChangesAsync();
            await _unitOfWork.SeatingCapacities.Insert(SeatingCapacitie);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSeatingCapacitie", new { id = SeatingCapacitie.Id }, SeatingCapacitie);
        }

        // DELETE: api/SeatingCapacities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeatingCapacitie(int id)
        {
            //Refactored
            //var SeatingCapacitie = await _context.SeatingCapacities.FindAsync(id);
            var SeatingCapacitie = await _unitOfWork.SeatingCapacities.Get(q => q.Id == id);
            if (SeatingCapacitie == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.SeatingCapacities.Remove(SeatingCapacitie);
            //await _context.SaveChangesAsync();
            await _unitOfWork.SeatingCapacities.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SeatingCapacitieExists(int id)
        {
            //Refactored
            //return (_context.SeatingCapacities?.Any(e => e.Id == id)).GetValueOrDefault();
            var SeatingCapacitie = await _unitOfWork.SeatingCapacities.Get(q => q.Id == id);
            return SeatingCapacitie != null;
        }
    }
}
