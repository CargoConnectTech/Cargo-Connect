using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserViewDTO>> GetAllAsync();
        Task<UserViewDTO> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(UserCreateDTO userreateDto);
        Task<bool> UpdateAsync(UserUpdateDTO userUpdateDto);
        Task<bool> DeleteAsync(Guid id);
    }
}
