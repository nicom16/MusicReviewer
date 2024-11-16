using MusicReviewer.Application.AuthenticationService.Dtos;
using MusicReviewer.Application.Repositories;

namespace MusicReviewer.Application.AuthenticationService.Interfaces
{
    public interface IAuthenticationService
    {
        RegisteredUserDto AuthenticateUser(LoginRequest loginRequest);
    }
}
