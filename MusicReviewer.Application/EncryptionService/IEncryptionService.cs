namespace MusicReviewer.Application.EncryptionService;

public interface IEncryptionService
{
    string Encrypt(string plainText);
}