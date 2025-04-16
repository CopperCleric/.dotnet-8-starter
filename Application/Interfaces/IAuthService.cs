using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAuthService
    {
        string GenerateJwtToken(User user);
    }
}
