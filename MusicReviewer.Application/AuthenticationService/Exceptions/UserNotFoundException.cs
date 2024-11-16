namespace MusicReviewer.Application.AuthenticationService.Exceptions
{
    public class UserNotFoundException : AuthenticationServiceException
    {
        private static readonly string _message = "No user was found with the specified username!";

        public UserNotFoundException() : base(_message) { }
    }
}
