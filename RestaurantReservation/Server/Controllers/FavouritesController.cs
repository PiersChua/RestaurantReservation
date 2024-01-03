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
	public class FavouritesController : ControllerBase
	{
		//Refactored
		//private readonly ApplicationDbContext _context;
		private readonly IUnitOfWork _unitOfWork;

		public FavouritesController(IUnitOfWork unitOfWork)
		{
			//Refactored
			//_context = context;
			_unitOfWork = unitOfWork;
		}

		// GET: api/Favourites
		[HttpGet]
		//Refactored
		//public async Task<ActionResult<IEnumerable<Favourite>>> GetFavourites()
		public async Task<IActionResult> GetFavourites()
		{
			//Refactored
			//return await _context.Favourites.ToListAsync();
			var favourites = await _unitOfWork.Favourites.GetAll(includes: q => q.Include(x => x.Customer).Include(x => x.Restaurant));
			return Ok(favourites);
		}

		// GET: api/Favourites/5
		[HttpGet("{id}")]
		//Refactored
		//public async Task<ActionResult<Favourite>> GetFavourite(int id)
		public async Task<IActionResult> GetFavourite(int id)
		{
			//Refactored    
			//var favourite = await _context.Favourites.FindAsync(id);
			var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);

			if (favourite == null)
			{
				return NotFound();
			}
			//Refactored
			return Ok(favourite);
		}

		// PUT: api/Favourites/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutFavourite(int id, Favourite favourite)
		{
			if (id != favourite.Id)
			{
				return BadRequest();
			}
			//Refactored
			//_context.Entry(favourite).State = EntityState.Modified;
			_unitOfWork.Favourites.Update(favourite);

			try
			{
				//Refactored
				//await _context.SaveChangesAsync();\
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				//Refactored
				// if(!FavouriteExists(id))
				if (!await FavouriteExists(id))
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

		// POST: api/Favourites
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Favourite>> PostFavourite(Favourite favourite)
		{
			//Refactored
			//_context.Favourites.Add(favourite);
			//await _context.SaveChangesAsync();
			await _unitOfWork.Favourites.Insert(favourite);
			await _unitOfWork.Save(HttpContext);

			return CreatedAtAction("GetFavourite", new { id = favourite.Id }, favourite);
		}

		// DELETE: api/Favourites/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteFavourite(int id)
		{
			//Refactored
			//var favourite = await _context.Favourites.FindAsync(id);
			var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);
			if (favourite == null)
			{
				return NotFound();
			}

			//Refactored
			//_context.Favourites.Remove(favourite);
			//await _context.SaveChangesAsync();
			await _unitOfWork.Favourites.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> FavouriteExists(int id)
		{
			//Refactored
			//return (_context.Favourites?.Any(e => e.Id == id)).GetValueOrDefault();
			var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);
			return favourite != null;
		}
	}
}
