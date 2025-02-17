using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Models.Model;

namespace Ticket.Services.Interface
{
     public interface IBookingService
    {
        Task<List<BookingModel>> GetAll();
        Task<BookingModel> CreateBooking(BookingModel booking);
        Task<BookingModel> GetByid(Guid bookingid);
    }
}
