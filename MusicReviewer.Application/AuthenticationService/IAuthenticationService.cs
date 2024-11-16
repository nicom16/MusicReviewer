using MusicReviewer.Application.Repositories;

namespace MusicReviewer.Application.AuthenticationService
{
    public interface IAuthenticationService
    {
        RegisteredUserDto AuthenticateUser(LoginRequest loginRequest);
    }
}
