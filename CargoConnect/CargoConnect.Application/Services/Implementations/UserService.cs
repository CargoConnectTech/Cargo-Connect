using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CargoConnect.Application.Services.Interfaces;
using CargoConnect.Domain.Entities;
using CargoConnect.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CargoConnect.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        IMappingService _mapper;
        IGenericRepository<UserEntity> _userRepository;

        public UserService(IMappingService mapper, IGenericRepository<UserEntity> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public Task<bool> CreateAsync(UserCreateDTO userreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserViewDTO>> GetAllAsync()
        {
            var users = _mapper.Map<List<UserEntity>, List<UserViewDTO>>(await _userRepository.GetAllAsync());
            return users;
        }

        public Task<UserViewDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UserUpdateDTO userUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
