using CargoConnect.Application.DTOs.Tracking;
using CargoConnect.Application.Interfaces;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CargoConnect.Application.Services
{
    public class TrackingService : ITrackingService
    {
        private readonly IMappingService _mapper;
        private readonly IGenericRepository<TrackingEntity> _trackingRepository;

        public TrackingService(
            IMappingService mapper,
            IGenericRepository<TrackingEntity> trackingRepository)
        {
            _mapper = mapper;
            _trackingRepository = trackingRepository;
        }

        public async Task<List<TrackingViewDTO>> GetAllAsync()
        {
            var trackingList = await _trackingRepository.GetAllAsync();
            return _mapper.MapList<TrackingEntity, TrackingViewDTO>(trackingList);
        }

        public async Task<TrackingViewDTO> GetByIdAsync(Guid id)
        {
            var tracking = await _trackingRepository.GetByIdAsync(id);
            return _mapper.Map<TrackingEntity, TrackingViewDTO>(tracking);
        }

        public async Task<bool> UpdateAsync(TrackingUpdateDTO trackingUpdateDto)
        {
            var entity = _mapper.Map<TrackingUpdateDTO, TrackingEntity>(trackingUpdateDto);
            return await _trackingRepository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _trackingRepository.DeleteAsync(id);
        }
    }
}