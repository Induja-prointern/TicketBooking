using Microsoft.AspNetCore.Mvc;
using Ticket.Models.Model;
using Ticket.Services.Implementation;
using Ticket.Services.Interface;

namespace Ticket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
       
        private readonly IBusService _busService;
        public BusController(IBusService busService)
        {
            _busService = busService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            List<BusModel> bus = await _busService.GetALl();
            return Ok(bus);
        }
        [HttpGet("getById/{{busid}}")]
        public async Task<IActionResult> GetByid(Guid busid)
        {
            BusModel bus = await _busService.GetByid(busid);
            return Ok(bus);
            
        }
        [HttpPost]
        public async Task<IActionResult> AddBus([FromBody] BusModel busModel)
        {
            if (busModel == null)
            {
                return BadRequest("User data is null.");
            }


            BusModel createdbus = await _busService.AddBus(busModel);
            return CreatedAtAction(nameof(GetByid), new { id = createdbus.busid }, createdbus);
        }
    }
}
