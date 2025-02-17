using Microsoft.AspNetCore.Mvc;
using Ticket.Models.Model;
using Ticket.Services.Implementation;
using Ticket.Services.Interface;

namespace Ticket.API.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            List<PaymentModel> payment = await _paymentService.GetALl();
            return Ok(payment);
        }
        [HttpGet("getById/{{paymnetid}}")]
        public async Task<IActionResult> GetByid(int paymnetid)
        {
            PaymentModel payment = await _paymentService.GetByid(paymnetid);
            return Ok(payment);
        }
    
    [HttpPost]

        public async Task<IActionResult> AddPay([FromBody] PaymentModel paymentModel)
        {
            if (paymentModel == null)
            {
                return BadRequest("User data is null.");
            }


            PaymentModel createdpayment = await _paymentService.AddPay(paymentModel);
            return CreatedAtAction(nameof(GetByid), new { id = createdpayment.paymnetid }, createdpayment);
        }
    }
}