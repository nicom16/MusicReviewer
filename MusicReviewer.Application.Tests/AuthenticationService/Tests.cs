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
            _authenticationService = new App.AuthenticationService();
        }

        [Test]
        public void AuthenticateUser_OnUser_ReturnsAuthenticationResult()
        {
            var userDto = new App.LoginRequest() 
                .WithValidUsername()
                .WithCorrectPassword();

            var authenticationResult = _authenticationService.AuthenticateUser(userDto);

            Assert.IsNotNull(authenticationResult);
        }
    }
}
