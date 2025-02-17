using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Models.Model;

namespace Ticket.Services.Interface
{
   public  interface IUserService
    {
        Task<List<UserModel>> GetAll();
        Task<UserModel> GetByid(Guid uid);
        Task<UserModel> AddUser(UserModel user );
    }
}
