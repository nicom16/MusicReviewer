using MusicReviewer.Application.AuthenticationService.Implementations;
using MusicReviewer.Application.EncryptionService;

namespace MusicReviewer.Application.Tests.AuthenticationService;

internal class StubEncryptionService : IEncryptionService
{
    internal StubEncryptionService() { }
    
    public string Encrypt(string plainText)
    {
        return plainText;
    }
}