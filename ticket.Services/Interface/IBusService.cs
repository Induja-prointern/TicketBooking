using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Models.Model;

namespace Ticket.Services.Interface
{
    public  interface IBusService
    {
        Task<List<BusModel>> GetALl();
        Task<BusModel> GetByid(Guid busid);
        Task<BusModel> AddBus(BusModel bus);
    }
}
