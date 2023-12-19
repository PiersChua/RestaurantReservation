using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Server.Data;
using RestaurantReservation.Server.IRepository;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Restaurants
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestaurants()
        public async Task<IActionResult> GetRestaurants()
        {
            //Refactored
            //return await _context.Restaurants.ToListAsync();
            var restaurants = await _unitOfWork.Restaurants.GetAll(includes:q=>q.Include(x=>x.Address).Include(x=>x.RestaurantOwner).Include(x=>x.Subscription));
            return Ok(restaurants);
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        public async Task<IActionResult> GetRestaurant(int id)
        {
            //Refactored    
            //var restaurant = await _context.Restaurants.FindAsync(id);
            var restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);

            if (restaurant == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(restaurant);
        }

        // PUT: api/Restaurants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurant(int id, Restaurant restaurant)
        {
            if (id != restaurant.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(restaurant).State = EntityState.Modified;
            _unitOfWork.Restaurants.Update(restaurant);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!RestaurantExists(id))
                if (!await RestaurantExists(id))
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

        // POST: api/Restaurants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Restaurant>> PostRestaurant(Restaurant restaurant)
        {
            //Refactored
            //_context.Restaurants.Add(restaurant);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Restaurants.Insert(restaurant);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRestaurant", new { id = restaurant.Id }, restaurant);
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            //Refactored
            //var restaurant = await _context.Restaurants.FindAsync(id);
            var restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Restaurants.Remove(restaurant);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Restaurants.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RestaurantExists(int id)
        {
            //Refactored
            //return (_context.Restaurants?.Any(e => e.Id == id)).GetValueOrDefault();
            var restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);
            return restaurant != null;
        }
    }
}
