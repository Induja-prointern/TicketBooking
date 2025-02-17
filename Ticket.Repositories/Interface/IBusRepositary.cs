using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Repositories.Entities;

namespace Ticket.Repositories.Interface
{
   public interface IBusRepositary
    {
        Task<List<Bus>> GetAll();
        Task<Bus> GetByid(Guid busid);
        Task<Bus> AddBus(Bus bus);
    }
}
