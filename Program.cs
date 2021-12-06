using System;
using System.IO;

namespace mprog_lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = null;
                sr = new StreamReader("/home/mint/Desktop/doc");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found{ex.FileName}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }



        }
    }
}
