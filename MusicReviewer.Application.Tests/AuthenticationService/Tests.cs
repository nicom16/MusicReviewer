using MusicReviewer.Application.AuthenticationService.Exceptions;
using MusicReviewer.Application.Repositories;
using App = MusicReviewer.Application.AuthenticationService.Implementations;

namespace MusicReviewer.Application.Tests.AuthenticationService
{
    [TestFixture]
    internal class Tests
    {
        private MockRegisteredUserRepository _mockRegisteredUserRepository;
        private StubEncryptionService _stubEncryptionService;
        private App.AuthenticationService _authenticationService;

        [SetUp]
        public void SetUp()
        {
            _mockRegisteredUserRepository = new MockRegisteredUserRepository();
            _stubEncryptionService = new StubEncryptionService();
            _authenticationService = new App.AuthenticationService(_mockRegisteredUserRepository, _stubEncryptionService);
        }

        [Test]
        public void AuthenticateUser_OnExistingUser_ReturnsRegisteredUser()
        {
            RegisteredUser registeredUser = 
                _authenticationService.AuthenticateUser(Constants.EXISTING_USERNAME, Constants.CORRECT_PASSWORD);

            Assert.IsNotNull(registeredUser);
            _mockRegisteredUserRepository.AssertWasCalled();
        }

        [Test]
        public void AuthenticateUser_OnUnexistingUsername_ThrowsException()
        {
            Assert.Throws<UserNotFoundException>(() => _authenticationService.AuthenticateUser(Constants.UNEXISTING_USERNAME, Constants.CORRECT_PASSWORD));
            _mockRegisteredUserRepository.AssertWasCalled();
        }
        
        [Test]
        public void AuthenticateUser_OnWrongPassword_ThrowsException()
        {
            Assert.Throws<InvalidPasswordException>(() => _authenticationService.AuthenticateUser(Constants.EXISTING_USERNAME, Constants.WRONG_PASSWORD));
            _mockRegisteredUserRepository.AssertWasCalled();
        }
    }
}
