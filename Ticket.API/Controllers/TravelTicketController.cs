using Microsoft.AspNetCore.Mvc;
using Ticket.Models.Model;
using Ticket.Services.Implementation;
using Ticket.Services.Interface;

namespace Ticket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelTicketController : ControllerBase
    {
        private readonly ITravelTicketService _travelService;
        public TravelTicketController(ITravelTicketService travelService)
        {
            _travelService = travelService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            List<TravelTicketModel> travelticket = await _travelService.GetAll();
            return Ok(travelticket);
        }
        [HttpGet("getById/{{ticketid}}")]
        public async Task<IActionResult> GetByid(int ticketid)
        {
            TravelTicketModel ticket = await _travelService.GetByid(ticketid);
            return Ok(ticket);
        }
        [HttpPost]

        public async Task<IActionResult> CreateTicket([FromBody] TravelTicketModel tTModel)
        {
            if (tTModel == null)
            {
                return BadRequest("User data is null.");
            }


            TravelTicketModel createdticket = await _travelService.AddTicket(tTModel);
            return CreatedAtAction(nameof(GetByid), new { id = createdticket.ticketid }, createdticket);
        }
    }
}
