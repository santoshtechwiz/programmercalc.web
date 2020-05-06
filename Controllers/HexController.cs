using System;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace programmercalc.web.Controllers
{
    public class HexController : Controller
    {
        public static string Hex(long number, int digits)
        {
            string str = Convert.ToString(number, 16);
            while (str.Length < digits)
                str = "0" + str;
            return str;
        }
        public static string HexViewer(Stream myFile)
        {
            int num1 = 0;
            string str = "";
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                byte[] buffer = new byte[16];
                int num2;
                do
                {
                    stringBuilder.Append(Hex(myFile.Position, 8));
                    stringBuilder.Append("   ");
                    num2 = myFile.Read(buffer, 0, 16);
                    for (int index = 0; index < num2; ++index)
                    {
                        stringBuilder.Append(Hex((long)buffer[index],
                                                 2) + "    ");
                        str = buffer[index] >= (byte)32 ? str + (object)Convert.ToChar(buffer[index]) : str + ".";
                    }
                    if (num2 < 16)
                    {
                        for (int index = num2; index < 16; ++index)
                            stringBuilder.Append("  ");
                    }
                    stringBuilder.AppendLine(str);
                    str = "";
                    ++num1;
                    if (num1 == 24)
                        num1 = 0;
                }
                while (num2 == 16);
                myFile.Close();
            }
            catch (Exception ex)
            {
                
            }
            return stringBuilder.ToString();
        }
    }
}