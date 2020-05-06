using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace programmercalc.web.Services
{
   public static class Extension
  {
    public static string ConvertoBase64(this string input)
    {
      return !string.IsNullOrEmpty(input) ? Convert.ToBase64String(Encoding.UTF8.GetBytes(input)) : string.Empty;
    }

    public static string ConvertBase64ToString(this string input)
    {
      return !string.IsNullOrEmpty(input) ? Encoding.UTF8.GetString(Convert.FromBase64String(input)) : string.Empty;
    }

    public static string StringToBinary(this string strText)
    {
      if (string.IsNullOrEmpty(strText))
        return string.Empty;
      BitArray bitArray = new BitArray(Encoding.UTF8.GetBytes(strText));
      StringBuilder stringBuilder = new StringBuilder();
      foreach (bool flag in bitArray)
        stringBuilder.Append(flag ? "1" : "0");
      return stringBuilder.ToString();
    }

    public static string Md5(this string input)
    {
      return !string.IsNullOrEmpty(input) ? HashAlgorithm.Create(nameof (Md5)).ComputeHash(Encoding.UTF8.GetBytes(input)).ByteToHexString() : string.Empty;
    }

    public static string SHAAlgorithm(this string input, string algorithmName)
    {
      if (string.IsNullOrEmpty(input))
        return string.Empty;
      byte[] bytes = Encoding.UTF8.GetBytes(input);
      return HashAlgorithm.Create(algorithmName).ComputeHash(bytes).ByteToHexString();
    }

    public static string ByteToHexString(this byte[] buffer)
    {
      StringBuilder stringBuilder = new StringBuilder(4);
      foreach (byte num in buffer)
        stringBuilder.Append(num.ToString("x2"));
      return stringBuilder.ToString();
    }

    public static string ConvetToBase(this int number, int baseNumber)
    {
      return Extension.ToBin(number);
    }

    public static string ToOct(this int input)
    {
      string empty = string.Empty;
      for (; input != 0; input /= 8)
      {
        int num = input % 8;
        empty += (string) (object) num;
      }
     // return new string(((IEnumerable<char>) empty.ToCharArray()).Reverse<char>().ToArray<char>());
     return "";
    }

    public static string ToHex(this int input)
    {
      string[] strArray = new string[15]
      {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "A",
        "B",
        "C",
        "D",
        "E",
        "F"
      };
      string str = string.Empty;
      for (; input != 0; input /= 16)
      {
        int index = input % 16 - 1;
        str = index <= 8 || index > 14 ? str + (object) (index + 1) : str + strArray[index];
      }
     /// return new string(((IEnumerable<char>)str.ToCharArray()).Reverse<char>()
                                     //                         .ToArray<char>());
                                     return "";
    }

    public static string ToBin(int n)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num = 0;
      while (num < 32)
      {
        if ((n & 1 << num) != 0)
          stringBuilder.Append("1");
        else
          stringBuilder.Append("0");
        ++num;
        if (num == 8 || num % 8 == 0)
          stringBuilder.Append(" ");
      }
     // return new string(((IEnumerable<char>) stringBuilder.ToString().ToCharArray()).Reverse<char>().ToArray<char>());
     return "";
    }

    public static int ToInt(this string input)
    {
      return !string.IsNullOrEmpty(input) ? Convert.ToInt32(input) : 0;
    }
    
  }
}