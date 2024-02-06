using Proiect_Backend.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proiect_Backend.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int userId);
        Task<UserDto> CreateUserAsync(CreateUserDto createUserDto);
        Task UpdateUserAsync(int userId, UpdateUserDto updateUserDto);
        Task DeleteUserAsync(int userId);
    }
}
