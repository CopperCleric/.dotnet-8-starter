using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<PagedResponse<User>> GetUsersPaginatedAsync(int pageNumber, int pageSize)
    {
        var users = await _userRepository.GetUsersPaginatedAsync(pageNumber, pageSize);
        var totalUsers = await _userRepository.GetTotalUsersCountAsync();

        var totalPages = (int)Math.Ceiling(totalUsers / (double)pageSize);

        return new PagedResponse<User>
        {
            Data = users,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalRecords = totalUsers,
            TotalPages = totalPages
        };
    }

    public async Task<User?> GetUserByIdAsync(Guid id) =>
        await _userRepository.GetUserByIdAsync(id);

    public async Task<User> RegisterUserAsync(User user)
    {
        user.Id = Guid.NewGuid();
        await _userRepository.AddUserAsync(user);
        return user;
    }

    public async Task UpdateUserAsync(User user) =>
        await _userRepository.UpdateUserAsync(user);

    public async Task DeleteUserAsync(Guid id) =>
        await _userRepository.DeleteUserAsync(id);
}
