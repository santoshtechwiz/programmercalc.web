using System.ComponentModel.DataAnnotations;

namespace programmercalc.web.Models
{
    public class RSAViewModel
  {
    [Required]
    public string PlainText { get; set; }

    public string CipherText { get; set; }

    public string PublicKey { get; set; }

    public string PrivateKey { get; set; }

    public string DecryptedText { get; set; }
  }
}