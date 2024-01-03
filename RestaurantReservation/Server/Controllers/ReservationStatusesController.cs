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
    public class ReservationStatusesController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ReservationStatusesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/ReservationStatuses
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<ReservationStatus>>> GetReservationStatuses()
        public async Task<IActionResult> GetReservationStatuses()
        {
            //Refactored
            //return await _context.ReservationStatuses.ToListAsync();
            var reservationstatusstatuses = await _unitOfWork.ReservationStatuses.GetAll();
            return Ok(reservationstatusstatuses);
        }

        // GET: api/ReservationStatuses/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<ReservationStatus>> GetReservationStatus(int id)
        public async Task<IActionResult> GetReservationStatus(int id)
        {
            //Refactored    
            //var reservationstatus = await _context.ReservationStatuses.FindAsync(id);
            var reservationstatus = await _unitOfWork.ReservationStatuses.Get(q => q.Id == id);

            if (reservationstatus == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(reservationstatus);
        }

        // PUT: api/ReservationStatuses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservationStatus(int id, ReservationStatus reservationstatus)
        {
            if (id != reservationstatus.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(reservationstatus).State = EntityState.Modified;
            _unitOfWork.ReservationStatuses.Update(reservationstatus);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!ReservationStatusExists(id))
                if (!await ReservationStatusExists(id))
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

        // POST: api/ReservationStatuses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReservationStatus>> PostReservationStatus(ReservationStatus reservationstatus)
        {
            //Refactored
            //_context.ReservationStatuses.Add(reservationstatus);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ReservationStatuses.Insert(reservationstatus);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReservationStatus", new { id = reservationstatus.Id }, reservationstatus);
        }

        // DELETE: api/ReservationStatuses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservationStatus(int id)
        {
            //Refactored
            //var reservationstatus = await _context.ReservationStatuses.FindAsync(id);
            var reservationstatus = await _unitOfWork.ReservationStatuses.Get(q => q.Id == id);
            if (reservationstatus == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.ReservationStatuses.Remove(reservationstatus);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ReservationStatuses.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ReservationStatusExists(int id)
        {
            //Refactored
            //return (_context.ReservationStatuses?.Any(e => e.Id == id)).GetValueOrDefault();
            var reservationstatus = await _unitOfWork.ReservationStatuses.Get(q => q.Id == id);
            return reservationstatus != null;
        }
    }
}
