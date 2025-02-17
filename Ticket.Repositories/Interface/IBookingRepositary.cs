using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Repositories.Entities;

namespace Ticket.Repositories.Interface
{
   public  interface IBookingRepositary
    {
        Task<List<Booking>> GetAll();
        Task<Booking> AddBooking(Booking booking);
        Task<Booking> GetByid(Guid bookingid);

    }
}
