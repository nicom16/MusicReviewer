using System.Security.Cryptography;
using System.Text;

namespace MusicReviewer.Application.Tests.Sha256EncryptionService;

[TestFixture]
public class Tests
{
    private EncryptionService.Sha256EncryptionService _service;
    
    [SetUp]
    public void Setup()
    {
        _service = new EncryptionService.Sha256EncryptionService();
    }
    
    [Test]
    public void EncryptTest()
    {
        string plainText = "Hello World!";
        string encryptedText = _service.Encrypt(plainText);
        Assert.IsTrue(encryptedText.Equals(ComputeHash(plainText)));     
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