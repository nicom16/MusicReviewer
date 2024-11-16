using MusicReviewer.Application.AuthenticationService.Dtos;
using MusicReviewer.Application.AuthenticationService.Exceptions;
using MusicReviewer.Application.AuthenticationService.Interfaces;
using MusicReviewer.Application.Repositories;

namespace MusicReviewer.Application.AuthenticationService.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRegisteredUserRepository _registeredUserRepository;

        public AuthenticationService(IRegisteredUserRepository registeredUserRepository)
        {
            _registeredUserRepository = registeredUserRepository;
        }

        public RegisteredUserDto AuthenticateUser(LoginRequest loginRequest)
        {
            RegisteredUserDto registeredUserDto =
                _registeredUserRepository.GetRegisteredUserByUsername(loginRequest.Username);

            if (registeredUserDto == null)
                throw new UserNotFoundException();

            if (registeredUserDto.Password != loginRequest.Password)
                throw new InvalidPasswordException();

            return registeredUserDto;
        }
    }
}
