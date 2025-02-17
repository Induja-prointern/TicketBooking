using Microsoft.AspNetCore.Mvc;
using Ticket.Models.Model;
using Ticket.Services.Interface;

namespace Ticket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetByid()
        {
            List<BookingModel> booking = await _bookingService.GetAll();
            return Ok(booking);
        }
        [HttpGet("getById/{{bookingid}}")]
        public async Task<IActionResult> GetByid(Guid bookingid)
        {
            BookingModel booking = await _bookingService.GetByid(bookingid);
            return Ok(booking);
        }

        [HttpPost]

        public async Task<IActionResult> CreateBooking([FromBody] BookingModel bookingModel)
        {
            if (bookingModel == null)
            {
                return BadRequest("User data is null.");
            }


            BookingModel createdbooking = await _bookingService.CreateBooking(bookingModel);
            return CreatedAtAction(nameof(GetByid), new { id = createdbooking.bookingid }, createdbooking);
        }
    }
}
