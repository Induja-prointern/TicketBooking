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
   public class UserRepositary : IUserRepositary
    {
        private readonly AppDbContext _context;
        public UserRepositary(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<User> GetByid(Guid uid)
        {
            return await _context.Users.FindAsync();
        }
        public async Task<User> AddUser(User user)
        {
            _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
