namespace MusicReviewer.Application.Repositories
{
    public record RegisteredUserDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}