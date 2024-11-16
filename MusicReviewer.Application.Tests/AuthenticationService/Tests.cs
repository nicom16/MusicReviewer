using Moq;
using MusicReviewer.Application.AuthenticationService.Exceptions;
using MusicReviewer.Application.Repositories;
using App = MusicReviewer.Application.AuthenticationService.Implementations;
using Dtos = MusicReviewer.Application.AuthenticationService.Dtos;

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
                Username = Constants.EXISTING_USERNAME, 
                Password = Constants.CORRECT_PASSWORD 
            };
            registeredUserRepository 
                .Setup(x => x.GetRegisteredUserByUsername(Constants.EXISTING_USERNAME))
                .Returns(expectedOutput);

            _authenticationService = new App.AuthenticationService(registeredUserRepository.Object);
        }

        [Test]
        public void AuthenticateUser_OnExistingUser_ReturnsRegisteredUser()
        {
            var userDto = new Dtos.LoginRequest() 
                .WithExistingUsername()
                .WithCorrectPassword();

            RegisteredUserDto registeredUserDto = _authenticationService.AuthenticateUser(userDto);

            Assert.IsNotNull(registeredUserDto);
        }

        [Test]
        public void AuthenticateUser_OnUnexistingUsername_ThrowsException()
        {
            var userDto = new Dtos.LoginRequest() 
                .WithExistingUsername()
                .WithCorrectPassword();

            RegisteredUserDto registeredUserDto = _authenticationService.AuthenticateUser(userDto);

            //Assert.Throws();
        }
    }
}
