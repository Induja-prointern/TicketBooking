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

        // Get all users
        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        // Get a user by ID (fixed the FindAsync method)
        public async Task<User> GetByid(Guid uid)
        {
            return await _context.Users.FindAsync(uid); // Pass the 'uid' parameter here
        }

        // Add a new user
        public async Task<User> AddUser(User user)
        {
            await _context.Users.AddAsync(user); // Fixed async call
            await _context.SaveChangesAsync();
            return user;
        }

        // Delete user by ID
        public async Task<User> DeleteUserById(Guid uid)
        {
            var user = await _context.Users.FindAsync(uid);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }
    }
}
