namespace MusicReviewer.Application.Repositories
{
    public record RegisteredUser
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
    }
}