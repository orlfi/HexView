using System;
using System.IO;

namespace HexView
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //if (args.Length == 0)
                //    throw (new Exception("Необходимо задать имя файла"));


                Byte[] bytes = File.ReadAllBytes(@"c:\tmp\obuh.cer");
                PrintHexTable(bytes);
            }
            catch (Exception ex)
            {
                
            }
        }

        static void PrintHexTable(byte[] bytes)
        {
            int index = 0;

            while(index < bytes.Length)
            {
                PrintLine(bytes, ref index);
            }
        }
        
        static void PrintLine(byte[] bytes, ref int index)
        {
            string text= "";
            string hex = "";
            for (int i = 0; i < 16; i++)
            {
                if (index > bytes.Length - 1)
                    break;
                hex += $"{bytes[index]:X2}  ";
                text += bytes[index]>40? ((char)bytes[index]).ToString():" ";
                index++;
            }
            Console.WriteLine(hex.PadRight(68) + text.PadRight(16));

        }


    }
}
