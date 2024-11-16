namespace MusicReviewer.Application.AuthenticationService.Exceptions
{
    public class InvalidPasswordException : AuthenticationServiceException
    {
        private static readonly string _message = "The provided password is wrong!";

        public InvalidPasswordException() : base(_message) { }
    }
}
