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
        private readonly IUserService _userService; // Add IUserService to check if user exists

        // Inject both the IBookingService and IUserService
        public BookingController(IBookingService bookingService, IUserService userService)
        {
            _bookingService = bookingService;
            _userService = userService;
        }

        // GET all bookings
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            List<BookingModel> booking = await _bookingService.GetAll();
            return Ok(booking);
        }

        // GET booking by ID
        [HttpGet("getById/{bookingid}")]
        public async Task<IActionResult> GetByid(Guid bookingid)
        {
            BookingModel booking = await _bookingService.GetByid(bookingid);
            return Ok(booking);
        }

        // POST to create a new booking
        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] BookingModel bookingModel)
        {
            if (bookingModel == null)
            {
                return BadRequest("Booking data is null.");
            }

            // Check if the user exists before proceeding with booking creation
            var user = await _userService.GetByid(bookingModel.uid); // Assuming UserId is part of the BookingModel
            if (user == null)
            {
                return BadRequest("User with the provided ID does not exist.");
            }

            // Create the booking if the user exists
            BookingModel createdBooking = await _bookingService.CreateBooking(bookingModel);

            // Return the created booking with a 201 status and the created booking's location
            return CreatedAtAction(nameof(GetByid), new { bookingid = createdBooking.bookingid }, createdBooking);
        }
    }
}
