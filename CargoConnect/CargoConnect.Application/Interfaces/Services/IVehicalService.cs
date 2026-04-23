using CargoConnect.Application.DTOs.Vehical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Interfaces.Services
{
    public interface IVehicalService
    {
        Task<List<VehicalViewDTO>> GetAllAsync();
        Task<VehicalViewDTO> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(VehicalCreateDTO vehicalCreateDTO);
        Task<bool> UpdateAsync(VehicalUpdateDTO vehicalUpdateDTO);
        Task<bool> DeleteAsync(Guid id);
    }
}
