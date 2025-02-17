using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Models.Model;

namespace Ticket.Services.Interface
{
    public interface ITravelTicketService
    {
        Task<List<TravelTicketModel>> GetAll();
        Task<TravelTicketModel> GetByid(int ticketid);
        Task<TravelTicketModel> AddTicket(TravelTicketModel ttiket);
    }
}
