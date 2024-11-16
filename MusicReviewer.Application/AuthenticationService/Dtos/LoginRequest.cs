namespace MusicReviewer.Application.AuthenticationService.Dtos
{
    public record LoginRequest
    {
        public string Username;
        public string Password;
    }
}