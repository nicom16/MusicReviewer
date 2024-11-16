using App = MusicReviewer.Application.AuthenticationService;

namespace MusicReviewer.Application.Tests.AuthenticationService
{
    internal static class Helpers
    {
        internal static App.LoginRequest WithValidUsername(this App.LoginRequest userLogginInDto)
        {
            userLogginInDto.Username = Constants.VALID_USERNAME;
            return userLogginInDto;
        }

        internal static App.LoginRequest WithCorrectPassword(this App.LoginRequest userLogginInDto)
        {
            userLogginInDto.Password = Constants.CORRECT_PASSWORD;
            return userLogginInDto;
        }

        internal static App.LoginRequest WithWrongPassword(this App.LoginRequest userLogginInDto)
        {
            userLogginInDto.Password = Constants.WRONG_PASSWORD;
            return userLogginInDto;
        }
    }
}
