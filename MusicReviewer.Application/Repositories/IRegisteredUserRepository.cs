namespace MusicReviewer.Application.Repositories
{
    public interface IRegisteredUserRepository
    {
        RegisteredUser GetRegisteredUserByUsername(string username); 
    }
}