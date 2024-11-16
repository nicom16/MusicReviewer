namespace MusicReviewer.Application.AuthenticationService
{
    public record LoginRequest
    {
        public string Username;
        public string Password;
    }
}