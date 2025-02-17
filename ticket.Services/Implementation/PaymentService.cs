using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ticket.Models.Model;
using Ticket.Repositories.Entities;
using Ticket.Repositories.Interface;
using Ticket.Services.Interface;

namespace Ticket.Services.Implementation
{
    public class PaymentService : IPaymentService
    {
        private readonly IMapper _mapper;
        private readonly IPaymentRepositary _payRepo;
        public PaymentService(IPaymentRepositary payRepo, IMapper mapper)
        {
            _mapper = mapper;
            _payRepo = payRepo;
        }
        public async Task<List<PaymentModel>> GetALl()
        {
            List<Payment> pays = await _payRepo.GetAll();
            List<PaymentModel> payModels = _mapper.Map<List<PaymentModel>>(pays);
            return payModels;
        }
        public async Task<PaymentModel> GetByid(int paymnetid)
        {
            Payment payments = await _payRepo.GetByid(paymnetid);
            PaymentModel pModel = _mapper.Map<PaymentModel>(payments);
            return pModel;
        }
        public async Task<PaymentModel> AddPay(PaymentModel payment)
        {

            Payment paymentEntity = _mapper.Map<Payment>(payment);
            
            Payment createdPayment = await _payRepo.AddPay(paymentEntity);
            return _mapper.Map<PaymentModel>(createdPayment);
        }
    }
}
