using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Repositories.Entities;

namespace Ticket.Repositories.Interface
{
     public interface IPaymentRepositary
    {
        Task<List<Payment>> GetAll();
        Task<Payment> GetByid(int paymnetid);
        Task<Payment> AddPay(Payment payment);
    }
}
