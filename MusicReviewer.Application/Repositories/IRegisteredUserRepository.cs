namespace MusicReviewer.Application.Repositories
{
    public interface IRegisteredUserRepository
    {
        RegisteredUserDto GetRegisteredUserByUsername(string username); 
    }
}