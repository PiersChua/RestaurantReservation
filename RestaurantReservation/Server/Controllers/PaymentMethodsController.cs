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
    public class PaymentMethodsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public PaymentMethodsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/PaymentMethods
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<PaymentMethod>>> GetPaymentMethods()
        public async Task<IActionResult> GetPaymentMethods()
        {
            //Refactored
            //return await _context.PaymentMethods.ToListAsync();
            var paymentmethods = await _unitOfWork.PaymentMethods.GetAll(includes:q=>q.Include(x=>x.Customer));
            return Ok(paymentmethods);
        }

        // GET: api/PaymentMethods/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<PaymentMethod>> GetPaymentMethod(int id)
        public async Task<IActionResult> GetPaymentMethod(int id)
        {
            //Refactored    
            //var paymentmethod = await _context.PaymentMethods.FindAsync(id);
            var paymentmethod = await _unitOfWork.PaymentMethods.Get(q => q.Id == id);

            if (paymentmethod == null)
            {
                return NotFound();
            }
            //Refactored
            return Ok(paymentmethod);
        }

        // PUT: api/PaymentMethods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentMethod(int id, PaymentMethod paymentmethod)
        {
            if (id != paymentmethod.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(paymentmethod).State = EntityState.Modified;
            _unitOfWork.PaymentMethods.Update(paymentmethod);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();\
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                // if(!PaymentMethodExists(id))
                if (!await PaymentMethodExists(id))
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

        // POST: api/PaymentMethods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentMethod>> PostPaymentMethod(PaymentMethod paymentmethod)
        {
            //Refactored
            //_context.PaymentMethods.Add(paymentmethod);
            //await _context.SaveChangesAsync();
            await _unitOfWork.PaymentMethods.Insert(paymentmethod);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPaymentMethod", new { id = paymentmethod.Id }, paymentmethod);
        }

        // DELETE: api/PaymentMethods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentMethod(int id)
        {
            //Refactored
            //var paymentmethod = await _context.PaymentMethods.FindAsync(id);
            var paymentmethod = await _unitOfWork.PaymentMethods.Get(q => q.Id == id);
            if (paymentmethod == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.PaymentMethods.Remove(paymentmethod);
            //await _context.SaveChangesAsync();
            await _unitOfWork.PaymentMethods.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PaymentMethodExists(int id)
        {
            //Refactored
            //return (_context.PaymentMethods?.Any(e => e.Id == id)).GetValueOrDefault();
            var paymentmethod = await _unitOfWork.PaymentMethods.Get(q => q.Id == id);
            return paymentmethod != null;
        }
    }
}
