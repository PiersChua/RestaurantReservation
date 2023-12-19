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
    public class AddressesController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public AddressesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Addresses
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Address>>> GetAddresses()
        public async Task<IActionResult> GetAddresses()
        {
            //Refactored
            //return await _context.Addresses.ToListAsync();
            var addresss = await _unitOfWork.Addresses.GetAll();
            return Ok(addresss);
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Address>> GetAddress(int id)
        public async Task<IActionResult> GetAddress(int id)
        {
            //Refactored    
            //var address = await _context.Addresses.FindAsync(id);
            var address = await _unitOfWork.Addresses.Get(q => q.Id == id);

            if (address == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(address);
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(int id, Address address)
        {
            if (id != address.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(address).State = EntityState.Modified;
            _unitOfWork.Addresses.Update(address);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!AddressExists(id))
                if (!await AddressExists(id))
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

        // POST: api/Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            //Refactored
            //_context.Addresses.Add(address);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Addresses.Insert(address);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAddress", new { id = address.Id }, address);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            //Refactored
            //var address = await _context.Addresses.FindAsync(id);
            var address = await _unitOfWork.Addresses.Get(q => q.Id == id);
            if (address == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Addresses.Remove(address);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Addresses.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AddressExists(int id)
        {
            //Refactored
            //return (_context.Addresses?.Any(e => e.Id == id)).GetValueOrDefault();
            var address = await _unitOfWork.Addresses.Get(q => q.Id == id);
            return address != null;
        }
    }
}
