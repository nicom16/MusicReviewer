using Moq;
using MusicReviewer.Application.Repositories;
using App = MusicReviewer.Application.AuthenticationService;

namespace MusicReviewer.Application.Tests.AuthenticationService
{
    [TestFixture]
    internal class Tests
    {
        private App.AuthenticationService _authenticationService;

        [SetUp]
        public void SetUp()
        {
            var registeredUserRepository = new Mock<IRegisteredUserRepository>();
            var expectedOutput = new RegisteredUserDto() 
            { 
                Id = Guid.NewGuid(), 
                Username = Constants.VALID_USERNAME, 
                Password = Constants.CORRECT_PASSWORD 
            };
            registeredUserRepository 
                .Setup(x => x.GetRegisteredUserByUsername(Constants.VALID_USERNAME))
                .Returns(expectedOutput);

            _authenticationService = new App.AuthenticationService(registeredUserRepository.Object);
        }

        [Test]
        public void AuthenticateUser_OnUser_ReturnsAuthenticationResult()
        {
            var userDto = new App.LoginRequest() 
                .WithValidUsername()
                .WithCorrectPassword();

            RegisteredUserDto registeredUserDto = _authenticationService.AuthenticateUser(userDto);

            Assert.IsNotNull(registeredUserDto);
        }
    }
}
