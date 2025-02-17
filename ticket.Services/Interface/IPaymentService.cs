using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.Models.Model;

namespace Ticket.Services.Interface
{
    public interface IPaymentService
    {
        Task<List<PaymentModel>> GetALl();
        Task<PaymentModel> GetByid(int paymnetid);
        Task<PaymentModel> AddPay(PaymentModel payment);
    }
}
