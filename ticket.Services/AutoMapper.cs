using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ticket.Models.Model;
using Ticket.Repositories.Entities;

namespace Ticket.Services
{
    public  class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Payment, PaymentModel>().ReverseMap();
            CreateMap<Booking, BookingModel>().ReverseMap();
            CreateMap<Bus, BusModel>().ReverseMap();
            CreateMap<TravelTicket, TravelTicketModel>().ReverseMap();
            
        }
    }
}
