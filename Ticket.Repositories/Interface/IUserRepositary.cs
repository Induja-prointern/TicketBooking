using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Repositories.Entities;

namespace Ticket.Repositories.Interface
{
    public interface IUserRepositary
    {
        Task<List<User>> GetAll();
        Task<User> GetByid(Guid uid);
        Task<User> AddUser(User user);
       
    }
}
