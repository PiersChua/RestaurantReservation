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
    public class ReservationsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ReservationsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reservations
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        public async Task<IActionResult> GetReservations()
        {
            //Refactored
            //return await _context.Reservations.ToListAsync();
            var reservations = await _unitOfWork.Reservations.GetAll(includes:q=>q.Include(x=>x.Customer).Include(x=>x.Restaurant).Include(x=>x.Promotion).Include(x=>x.ReservationStatus));
            return Ok(reservations);
        }

        // GET: api/Reservations/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Reservation>> GetReservation(int id)
        public async Task<IActionResult> GetReservation(int id)
        {
            //Refactored    
            //var reservation = await _context.Reservations.FindAsync(id);
            var reservation = await _unitOfWork.Reservations.Get(q => q.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(reservation);
        }

        // PUT: api/Reservations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservation(int id, Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(reservation).State = EntityState.Modified;
            _unitOfWork.Reservations.Update(reservation);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!ReservationExists(id))
                if (!await ReservationExists(id))
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

        // POST: api/Reservations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation(Reservation reservation)
        {
            //Refactored
            //_context.Reservations.Add(reservation);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Reservations.Insert(reservation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReservation", new { id = reservation.Id }, reservation);
        }

        // DELETE: api/Reservations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            //Refactored
            //var reservation = await _context.Reservations.FindAsync(id);
            var reservation = await _unitOfWork.Reservations.Get(q => q.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Reservations.Remove(reservation);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Reservations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ReservationExists(int id)
        {
            //Refactored
            //return (_context.Reservations?.Any(e => e.Id == id)).GetValueOrDefault();
            var reservation = await _unitOfWork.Reservations.Get(q => q.Id == id);
            return reservation != null;
        }
    }
}
