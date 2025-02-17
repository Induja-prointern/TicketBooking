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



     public class BusService : IBusService 
    {
        private readonly IMapper _mapper;
        private readonly IBusRepositary _busRepo;
        public BusService(IBusRepositary busRepo, IMapper mapper)
        {
            _mapper = mapper;
            _busRepo = busRepo;
        }
        public async Task<List<BusModel>> GetALl()
        {
            List<Bus> buses = await _busRepo.GetAll();
            List<BusModel> busModels = _mapper.Map<List<BusModel>>(buses);
            return busModels;
        }
        public async Task<BusModel> GetByid(Guid busid)
        {
            Bus buses = await _busRepo.GetByid(busid);
            BusModel bModel = _mapper.Map<BusModel>(buses);
            return bModel;
        }
        public async Task<BusModel> AddBus(BusModel bus)
        {

            Bus busEntity = _mapper.Map<Bus>(bus);
            busEntity.busid = Guid.NewGuid();
            Bus createdBus = await _busRepo.AddBus(busEntity);
            return _mapper.Map<BusModel>(createdBus);
        }
    }
}
