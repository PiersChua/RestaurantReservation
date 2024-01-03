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
    public class OperatingHoursController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public OperatingHoursController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/OperatingHours
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<OperatingHour>>> GetOperatingHours()
        public async Task<IActionResult> GetOperatingHours()
        {
            //Refactored
            //return await _context.OperatingHours.ToListAsync();
            var operatinghours = await _unitOfWork.OperatingHours.GetAll(includes:q=>q.Include(x=>x.Restaurant));
            return Ok(operatinghours);
        }

        // GET: api/OperatingHours/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<OperatingHour>> GetOperatingHour(int id)
        public async Task<IActionResult> GetOperatingHour(int id)
        {
            //Refactored    
            //var operatinghour = await _context.OperatingHours.FindAsync(id);
            var operatinghour = await _unitOfWork.OperatingHours.Get(q => q.Id == id);

            if (operatinghour == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(operatinghour);
        }

        // PUT: api/OperatingHours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOperatingHour(int id, OperatingHour operatinghour)
        {
            if (id != operatinghour.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(operatinghour).State = EntityState.Modified;
            _unitOfWork.OperatingHours.Update(operatinghour);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!OperatingHourExists(id))
                if (!await OperatingHourExists(id))
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

        // POST: api/OperatingHours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OperatingHour>> PostOperatingHour(OperatingHour operatinghour)
        {
            //Refactored
            //_context.OperatingHours.Add(operatinghour);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OperatingHours.Insert(operatinghour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOperatingHour", new { id = operatinghour.Id }, operatinghour);
        }

        // DELETE: api/OperatingHours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOperatingHour(int id)
        {
            //Refactored
            //var operatinghour = await _context.OperatingHours.FindAsync(id);
            var operatinghour = await _unitOfWork.OperatingHours.Get(q => q.Id == id);
            if (operatinghour == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.OperatingHours.Remove(operatinghour);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OperatingHours.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> OperatingHourExists(int id)
        {
            //Refactored
            //return (_context.OperatingHours?.Any(e => e.Id == id)).GetValueOrDefault();
            var operatinghour = await _unitOfWork.OperatingHours.Get(q => q.Id == id);
            return operatinghour != null;
        }
    }
}
