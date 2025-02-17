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
     public class BookingService : IBookingService
    {
        private readonly IMapper _mapper;
        private readonly IBookingRepositary _bookingRepo;
        public BookingService(IBookingRepositary bookingRepo, IMapper mapper)
        {
            _mapper = mapper;
            _bookingRepo = bookingRepo;
        }
        public async Task<List<BookingModel>> GetAll()
        {
            List<Booking> bookings = await _bookingRepo.GetAll();
            List<BookingModel> bookingModels = _mapper.Map<List<BookingModel>>(bookings);
            return bookingModels;
        }
        public async Task<BookingModel> GetByid(Guid bookingid)
        {

            Booking booking = await _bookingRepo.GetByid(bookingid);
            return _mapper.Map<BookingModel>(booking);


        }
        public async Task<BookingModel> CreateBooking(BookingModel booking)
        {

            Booking bookingEntity = _mapper.Map<Booking>(booking);
            bookingEntity.bookingid = Guid.NewGuid();
            Booking createdBooking = await _bookingRepo.AddBooking(bookingEntity);
            return _mapper.Map<BookingModel>(createdBooking);
        }
        
    }
}
