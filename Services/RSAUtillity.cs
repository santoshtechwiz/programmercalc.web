using System;
using System.Security.Cryptography;
using System.Text;
using programmercalc.web.Models;

namespace programmercalc.web.Services
{
  public class RSAUtility
  {
    public static RSAViewModel rsa2(RSAViewModel model)
    {
      try
      {
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(1024);
        RSAParameters parameters1 = cryptoServiceProvider.ExportParameters(false);
        RSAParameters parameters2 = cryptoServiceProvider.ExportParameters(true);
        model.PublicKey = "e=" + RSAUtility.ByteToString(parameters1.Exponent) + Environment.NewLine + "n=" + RSAUtility.ByteToString(parameters1.Modulus);
        model.PrivateKey = "d=" + RSAUtility.ByteToString(parameters2.D) + Environment.NewLine + "n=" + RSAUtility.ByteToString(parameters1.Modulus);
        cryptoServiceProvider.ImportParameters(parameters1);
        byte[] numArray = cryptoServiceProvider.Encrypt(RSAUtility.StringToByte(model.PlainText), true);
        model.CipherText = RSAUtility.ByteToString(numArray);
        cryptoServiceProvider.ImportParameters(parameters2);
        byte[] decryptedData = cryptoServiceProvider.Decrypt(numArray, true);
        model.DecryptedText = RSAUtility.ByteToAscii(decryptedData);
      }
      catch (CryptographicException ex)
      {
      }
      return model;
    }

    private static string ByteToAscii(byte[] decryptedData)
    {
      return Encoding.UTF8.GetString(decryptedData);
    }

    private static byte[] StringToByte(string message)
    {
      return Encoding.UTF8.GetBytes(message);
    }

    private static string ByteToString(byte[] p)
    {
      return BitConverter.ToString(p).Replace("-", "");
    }
  }
}