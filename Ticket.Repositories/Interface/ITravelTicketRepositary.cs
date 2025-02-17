using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Repositories.Entities;

namespace Ticket.Repositories.Interface
{
    public interface ITravelTicketRepositary
    {
        Task<List<TravelTicket>> GetAll();
        Task<TravelTicket> GetByid(int ticketid);
        Task<TravelTicket> AddTicket(TravelTicket tticket);
    }
}
