using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App = MusicReviewer.Application.AuthenticationService;

namespace MusicReviewer.Application.Tests.AuthenticationService
{
    [TestFixture]
    internal class AuthenticationService_Tests
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
            var userDto = new App.UserLogginInDto();

            var authenticationResult = _authenticationService.AuthenticateUser(userDto);

            Assert.IsNotNull(authenticationResult);
        }
    }
}
