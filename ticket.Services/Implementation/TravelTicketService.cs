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
    public class TravelTicketService : ITravelTicketService
    {
        private readonly IMapper _mapper;
        private readonly ITravelTicketRepositary _travelRepo;
        public TravelTicketService(ITravelTicketRepositary travelRepo, IMapper mapper)
        {
            _mapper = mapper;
            _travelRepo = travelRepo;
        }
        public async Task<List<TravelTicketModel>> GetAll()
        {
            List<TravelTicket> traveltickets = await _travelRepo.GetAll();
            List<TravelTicketModel> travelModels = _mapper.Map<List<TravelTicketModel>>(traveltickets);
            return travelModels;
        }
        public async Task<TravelTicketModel> GetByid(int ticketid)
        {
            TravelTicket tticket = await _travelRepo.GetByid(ticketid);
            TravelTicketModel ttModel = _mapper.Map<TravelTicketModel>(tticket);
            return ttModel;


        }
        public async Task<TravelTicketModel> AddTicket(TravelTicketModel tTicket)
        {

            TravelTicket travelEntity = _mapper.Map<TravelTicket>(tTicket);
            
            TravelTicket createdTicket = await _travelRepo.AddTicket(travelEntity);
            return _mapper.Map<TravelTicketModel>(createdTicket);
        }
    }
}
