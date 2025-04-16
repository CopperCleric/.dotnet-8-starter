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

    public async Task<List<User>> GetAllUsersAsync() =>
        await _userRepository.GetAllUsersAsync();

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
