using MusicReviewer.Application.Repositories;

namespace MusicReviewer.Application.AuthenticationService.Interfaces
{
    public interface IAuthenticationService
    {
        RegisteredUser AuthenticateUser(string username, string password);
    }
}
