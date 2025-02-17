using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ticket.Repositories.Entities;
using Ticket.Repositories.Interface;

namespace Ticket.Repositories.Implementation
{
   public  class BookingRepositary : IBookingRepositary
    {
        private readonly AppDbContext _context;
        public BookingRepositary(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Booking>> GetAll()
        {
            return await _context.Bookings.ToListAsync();
        }
        public async Task<Booking> GetByid(Guid bookingid)
        {
            return await _context.Bookings.FindAsync();
        }

        public async Task<Booking> AddBooking(Booking booking)
        {
            _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
            return booking;

        }


    }
}
