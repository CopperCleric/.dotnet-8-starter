using Domain.Entities;

namespace Application.Interfaces;

public interface IUserService
{
    Task<PagedResponse<User>> GetUsersPaginatedAsync(int pageNumber, int pageSize);
    Task<User?> GetUserByIdAsync(Guid id);
    Task<User> RegisterUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(Guid id);
}

public class PagedResponse<T>
{
    public IEnumerable<T> Data { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalRecords { get; set; }
    public int TotalPages { get; set; }
}