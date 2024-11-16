using MusicReviewer.Application.AuthenticationService.Dtos;
using App = MusicReviewer.Application.AuthenticationService;

namespace MusicReviewer.Application.Tests.AuthenticationService
{
    internal static class Helpers
    {
        internal static LoginRequest WithExistingUsername(this LoginRequest userLogginInDto)
        {
            userLogginInDto.Username = Constants.EXISTING_USERNAME;
            return userLogginInDto;
        }
        
        internal static LoginRequest WithUnexistingUsername(this LoginRequest userLogginInDto)
        {
            userLogginInDto.Username = Constants.UNEXISTING_USERNAME;
            return userLogginInDto;
        }

        internal static LoginRequest WithCorrectPassword(this LoginRequest userLogginInDto)
        {
            userLogginInDto.Password = Constants.CORRECT_PASSWORD;
            return userLogginInDto;
        }

        internal static LoginRequest WithWrongPassword(this LoginRequest userLogginInDto)
        {
            userLogginInDto.Password = Constants.WRONG_PASSWORD;
            return userLogginInDto;
        }
    }
}
