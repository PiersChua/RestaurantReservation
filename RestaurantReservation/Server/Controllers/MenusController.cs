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
    public class MenusController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public MenusController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Menus
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Menu>>> GetMenus()
        public async Task<IActionResult> GetMenus()
        {
            //Refactored
            //return await _context.Menus.ToListAsync();
            var menus = await _unitOfWork.Menus.GetAll(includes: q => q.Include(x => x.Restaurant));
            return Ok(menus);
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Menu>> GetMenu(int id)
        public async Task<IActionResult> GetMenu(int id)
        {
            //Refactored    
            //var menu = await _context.Menus.FindAsync(id);
            var menu = await _unitOfWork.Menus.Get(q => q.Id == id);

            if (menu == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(menu);
        }

        // PUT: api/Menus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(menu).State = EntityState.Modified;
            _unitOfWork.Menus.Update(menu);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!MenuExists(id))
                if (!await MenuExists(id))
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

        // POST: api/Menus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menu>> PostMenu(Menu menu)
        {
            //Refactored
            //_context.Menus.Add(menu);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Menus.Insert(menu);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMenu", new { id = menu.Id }, menu);
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            //Refactored
            //var menu = await _context.Menus.FindAsync(id);
            var menu = await _unitOfWork.Menus.Get(q => q.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Menus.Remove(menu);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Menus.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MenuExists(int id)
        {
            //Refactored
            //return (_context.Menus?.Any(e => e.Id == id)).GetValueOrDefault();
            var menu = await _unitOfWork.Menus.Get(q => q.Id == id);
            return menu != null;
        }
    }
}
