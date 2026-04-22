using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Services.Interfaces
{
    public interface IDriverService
    {
        Task<List<DriverViewDTO>> GetAllAsync();
        Task<DriverViewDTO> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(DriverCreateDTO driverCreateDto);
        Task<bool> UpdateAsync(DriverUpdateDTO driverUpdateDto);
        Task<bool> DeleteAsync(Guid id);
    }
}
