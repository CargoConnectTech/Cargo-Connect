using CargoConnect.Application.DTOs.Vehical;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Services
{
   
        public class VehicalService : IVehicalService
        {
            IMappingService _mapper;
            IGenericRepository<VehicalEntity> _vehicalRepository;


            public VehicalService(IMappingService mapper, IGenericRepository<VehicalEntity> vehicalRepository)
            {
                _mapper = mapper;
                _vehicalRepository = vehicalRepository;
            }

            public async Task<bool> CreateAsync(VehicalCreateDTO vehicalCreateDto)
            {
                bool status = await _vehicalRepository.CreateAsync(_mapper.Map<VehicalCreateDTO, VehicalEntity>(vehicalCreateDto));
                return status;
            }


            public async Task<bool> DeleteAsync(Guid id)
            {
                bool status = await _vehicalRepository.DeleteAsync(id);
                return status;
            }

            public async Task<List<VehicalViewDTO>> GetAllAsync()
            {
                var vehicals = _mapper.MapList<VehicalEntity, VehicalViewDTO>(await _vehicalRepository.GetAllAsync());
                return vehicals;
            }


            public async Task<VehicalViewDTO> GetByIdAsync(Guid id)
            {
                var vehical = _mapper.Map<VehicalEntity, VehicalViewDTO>(await _vehicalRepository.GetByIdAsync(id));
                return vehical;
            }


            public async Task<bool> UpdateAsync(VehicalUpdateDTO vehicalUpdateDto)
            {
                bool status = await _vehicalRepository.UpdateAsync(_mapper.Map<VehicalUpdateDTO, VehicalEntity>(vehicalUpdateDto));
                return status;
            }
        }
    }
