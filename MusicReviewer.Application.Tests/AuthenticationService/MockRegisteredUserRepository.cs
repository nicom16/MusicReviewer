using MusicReviewer.Application.Repositories;

namespace MusicReviewer.Application.Tests.AuthenticationService;

internal class MockRegisteredUserRepository : IRegisteredUserRepository
{
    private bool _wasCalled;
    
    internal MockRegisteredUserRepository() { }
        
    public RegisteredUser GetRegisteredUserByUsername(string username)
    {
        _wasCalled = true;
            
        if (username != Constants.EXISTING_USERNAME)
            return null;
            
        return new RegisteredUser() 
        { 
            Id = Guid.NewGuid(), 
            Username = Constants.EXISTING_USERNAME, 
            EncryptedPassword = Constants.CORRECT_PASSWORD 
        };
    }

    internal void AssertWasCalled()
    {
        Assert.IsTrue(_wasCalled);
    }
}