using System.Text;
using System.Text.RegularExpressions;

namespace programmercalc.web.Services
{
    public static class CustomEncoding
    {
        public static string EncodeNonAsciiCharacters(this string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char ch in value)
            {
                if (ch > '\x007F')
                {
                    string str = "\\u" + ((int)ch).ToString("x4");
                    stringBuilder.Append(str);
                }
                else
                    stringBuilder.Append(ch);
            }
            return stringBuilder.ToString();
        }

        public static string DecodeEncodedNonAsciiCharacters(this string value)
        {
            return "something";
           // return Regex.Replace(value, "\\\\u(?<Value>[a-zA-Z0-9]{4})", (MatchEvaluator)(m => ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString()));
        }
    }
}