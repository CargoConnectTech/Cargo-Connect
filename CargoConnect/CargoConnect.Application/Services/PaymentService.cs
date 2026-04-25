using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.DTOs.Payment;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.Services
{
    public class PaymentService : IPaymentService
    {
        IMappingService _mapper;
        IGenericRepository<PaymentEntity> _repository;

        public PaymentService(IMappingService mapper, IGenericRepository<PaymentEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreateAsync(PaymentCreateDTO paymentCreateDTO)
        {
            var entity = _mapper.Map<PaymentCreateDTO, PaymentEntity>(paymentCreateDTO);
            bool status = await _repository.CreateAsync(entity);
            return status;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<PaymentViewDTO>> GetAllAsync()
        {
            return  _mapper.MapList<PaymentEntity, PaymentViewDTO>(await _repository.GetAllAsync());
        }

        public async Task<PaymentViewDTO> GetByIdAsync(Guid id)
        {
            return _mapper.Map<PaymentEntity, PaymentViewDTO>(await _repository.GetByIdAsync(id));
        }

        public async Task<bool> UpdateAsync(PaymentUpdateDTO paymentUpdateDTO)
        {
            return await _repository.UpdateAsync(_mapper.Map<PaymentUpdateDTO, PaymentEntity>(paymentUpdateDTO));
        }
    }
}
