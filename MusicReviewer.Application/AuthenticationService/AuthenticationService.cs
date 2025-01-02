using MusicReviewer.Application.AuthenticationService.Exceptions;
using MusicReviewer.Application.AuthenticationService.Interfaces;
using MusicReviewer.Application.EncryptionService;
using MusicReviewer.Application.Repositories;

namespace MusicReviewer.Application.AuthenticationService.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRegisteredUserRepository _registeredUserRepository;
        private readonly IEncryptionService _encryptionService;

        public AuthenticationService(
            IRegisteredUserRepository registeredUserRepository, 
            IEncryptionService encryptionService)
        {
            _registeredUserRepository = registeredUserRepository;
            _encryptionService = encryptionService;
        }

        public RegisteredUser AuthenticateUser(string username, string password)
        {
            RegisteredUser registeredUser =
                _registeredUserRepository.GetRegisteredUserByUsername(username);

            if (registeredUser == null)
                throw new UserNotFoundException();

            string encryptedPassword = _encryptionService.Encrypt(password);
            if (registeredUser.EncryptedPassword != encryptedPassword)
                throw new InvalidPasswordException();

            return registeredUser;
        }
    }
}
