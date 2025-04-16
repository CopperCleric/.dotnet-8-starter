using Domain.Entities;

namespace Application.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersPaginatedAsync(int pageNumber, int pageSize);
    Task<int> GetTotalUsersCountAsync();
    Task<User?> GetUserByIdAsync(Guid id);
    Task AddUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(Guid id);
}