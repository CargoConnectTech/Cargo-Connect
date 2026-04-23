using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.DTOs.Booking;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.Services
{
    public class BookingService : IBookingService
    {
        IMappingService _mapper;
        IGenericRepository<BookingEntity> _bookingRepository;
        public BookingService(IMappingService mappingService, IGenericRepository<BookingEntity> bookingRepository)
        {
            _mapper = mappingService;
            _bookingRepository = bookingRepository;
        }
        public async Task<bool> CreateAsync(BookingCreateDTO bookingCreateDto)
        {
            var entity = _mapper.Map<BookingCreateDTO, BookingEntity>(bookingCreateDto);
            return await _bookingRepository.CreateAsync(entity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var status = await _bookingRepository.DeleteAsync(id);
            return status;
        }

        public async Task<List<BookingViewDTO>> GetAllAsync()
        {
            var  bookings = _mapper.MapList<BookingEntity, BookingViewDTO>
                (await _bookingRepository.GetAllAsync());
            return bookings;
        }

        public async Task<BookingViewDTO> GetByIdAsync(Guid id)
        {
            var booking = _mapper.Map<BookingEntity, BookingViewDTO>(
             await _bookingRepository.GetByIdAsync(id));

            return booking;
        }

        public  async Task<bool> UpdateAsync(BookingUpdateDTO bookingUpdateDto)
        {
            bool status = await _bookingRepository
              .UpdateAsync(_mapper.Map<BookingUpdateDTO, BookingEntity>(bookingUpdateDto));

            return status;
        }
    }
}
