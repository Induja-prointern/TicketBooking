using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ticket.Repositories.Entities;
using Ticket.Repositories.Interface;

namespace Ticket.Repositories.Implementation
{
    public  class TravelTicketRepositary : ITravelTicketRepositary
    {
        private readonly AppDbContext _context;
        public TravelTicketRepositary(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<TravelTicket>> GetAll()
        {
            return await _context.Tickets.ToListAsync();

        }
        public async Task<TravelTicket> GetByid(int ticketid)
        {
            return await _context.Tickets.FindAsync();
        }
        public async Task<TravelTicket> AddTicket(TravelTicket tticket)
        {
            _context.Tickets.AddAsync(tticket);
            await _context.SaveChangesAsync();
            return tticket;

        }
    }
}
