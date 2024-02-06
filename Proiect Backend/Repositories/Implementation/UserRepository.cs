using Proiect_Backend.Data;
using Proiect_Backend.DTO;
using Proiect_Backend.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proiect_Backend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            return await _context.Users
                .Select(user => new UserDto { Username = user.Username })
                .ToListAsync();
        }

        public async Task<UserDto> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new User
            {
                Username = createUserDto.Username
                
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new UserDto { Username = user.Username };
        }

        public async Task UpdateUserAsync(int userId, UpdateUserDto updateUserDto)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                user.Username = updateUserDto.Username;
         

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteUserAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public Task<UserDto> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
