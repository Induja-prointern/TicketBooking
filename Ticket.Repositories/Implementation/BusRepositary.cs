using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Ticket.Repositories.Entities;
using Ticket.Repositories.Interface;

namespace Ticket.Repositories.Implementation
{
   public  class BusRepositary : IBusRepositary
    {
        private readonly AppDbContext _context;
        public BusRepositary(AppDbContext context)
        {
            _context = context;
        }
        public  async Task<List<Bus>> GetAll()
        {
            return await _context.Buses.ToListAsync();
        }
        public async Task<Bus> GetByid(Guid busid)
        {
            return await _context.Buses.FindAsync();
        }
        public async Task<Bus> AddBus(Bus bus)
        {
            _context.Buses.AddAsync(bus);
            await _context.SaveChangesAsync();
            return bus;

        }
    }
}
