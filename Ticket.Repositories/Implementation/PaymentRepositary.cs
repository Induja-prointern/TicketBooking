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
    public class PaymentRepositary : IPaymentRepositary
    {
        private readonly AppDbContext _context;
        public PaymentRepositary(AppDbContext context)
        {
            _context = context;

        }
        public async Task<List<Payment>> GetAll()
        {
            return await _context.Payments.ToListAsync();
        }
        public async Task<Payment> GetByid(int paymnetid)
        {
            return await _context.Payments.FindAsync();
        }
        public async Task<Payment> AddPay(Payment payment)
        {
            _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            return payment;
        }
    }
}
