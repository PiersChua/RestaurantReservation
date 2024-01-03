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
    public class RestaurantApplicationsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantApplicationsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/RestaurantApplications
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<RestaurantApplication>>> GetRestaurantApplications()
        public async Task<IActionResult> GetRestaurantApplications()
        {
            //Refactored
            //return await _context.RestaurantApplications.ToListAsync();
            var restaurantapplications = await _unitOfWork.RestaurantApplications.GetAll(includes:q=>q.Include(x=>x.Customer).Include(x=>x.Staff));
            return Ok(restaurantapplications);
        }

        // GET: api/RestaurantApplications/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<RestaurantApplication>> GetRestaurantApplication(int id)
        public async Task<IActionResult> GetRestaurantApplication(int id)
        {
            //Refactored    
            //var restaurantapplication = await _context.RestaurantApplications.FindAsync(id);
            var restaurantapplication = await _unitOfWork.RestaurantApplications.Get(q => q.Id == id);

            if (restaurantapplication == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(restaurantapplication);
        }

        // PUT: api/RestaurantApplications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurantApplication(int id, RestaurantApplication restaurantapplication)
        {
            if (id != restaurantapplication.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(restaurantapplication).State = EntityState.Modified;
            _unitOfWork.RestaurantApplications.Update(restaurantapplication);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!RestaurantApplicationExists(id))
                if (!await RestaurantApplicationExists(id))
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

        // POST: api/RestaurantApplications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RestaurantApplication>> PostRestaurantApplication(RestaurantApplication restaurantapplication)
        {
            //Refactored
            //_context.RestaurantApplications.Add(restaurantapplication);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RestaurantApplications.Insert(restaurantapplication);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRestaurantApplication", new { id = restaurantapplication.Id }, restaurantapplication);
        }

        // DELETE: api/RestaurantApplications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurantApplication(int id)
        {
            //Refactored
            //var restaurantapplication = await _context.RestaurantApplications.FindAsync(id);
            var restaurantapplication = await _unitOfWork.RestaurantApplications.Get(q => q.Id == id);
            if (restaurantapplication == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.RestaurantApplications.Remove(restaurantapplication);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RestaurantApplications.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RestaurantApplicationExists(int id)
        {
            //Refactored
            //return (_context.RestaurantApplications?.Any(e => e.Id == id)).GetValueOrDefault();
            var restaurantapplication = await _unitOfWork.RestaurantApplications.Get(q => q.Id == id);
            return restaurantapplication != null;
        }
    }
}
