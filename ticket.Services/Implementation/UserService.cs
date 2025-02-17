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
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepositary _userRepo;
        public UserService(IUserRepositary userRepo , IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }
        public async Task<List<UserModel>> GetAll()
        {
            List<User> users = await _userRepo.GetAll();
            List<UserModel> userModels =_mapper.Map<List<UserModel>> (users);
            return userModels;
        }
        public async Task<UserModel> GetByid(Guid uid)
        {
            User user = await _userRepo.GetByid(uid);
            return _mapper.Map<UserModel>(user);
           


        }
        public async Task<UserModel> AddUser(UserModel user)
        {

            User userEntity = _mapper.Map<User>(user);
            userEntity.uid = Guid.NewGuid();
            User createdUser = await _userRepo.AddUser(userEntity);
            return _mapper.Map<UserModel>(createdUser);
        }

    }
}
