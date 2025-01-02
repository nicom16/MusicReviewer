using System.Security.Cryptography;
using System.Text;

namespace MusicReviewer.Application.EncryptionService;

public class Sha256EncryptionService : IEncryptionService
{
    public Sha256EncryptionService() { }
    
    public string Encrypt(string plainText)
    {
        return ComputeHash(plainText);
    }

    private string ComputeHash(string plainText)
    {
        using SHA256 sha256Hash = SHA256.Create();
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
        {
            builder.Append(bytes[i].ToString("x2"));
        }
            
        return builder.ToString();
    }
}