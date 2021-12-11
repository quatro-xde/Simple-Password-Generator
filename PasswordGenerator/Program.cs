using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PasswordGenerator - Quatro";
            Console.WriteLine("\n Press any key to generate a password!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"\n\n {GetAlphanumericalString(12)}"+"\n\n\n Press enter 5 times to exit");
            Console.ReadKey();
            Console.WriteLine("\n\n 5");
            Console.ReadKey();
            Console.WriteLine("\n 4");
            Console.ReadKey();
            Console.WriteLine("\n 3");
            Console.ReadKey();
            Console.WriteLine("\n 2");
            Console.ReadKey();
            Console.WriteLine("\n 1");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static Random rand = new Random();
        public static List<string> UsedStrings = new List<string>();
        public static string GetAlphanumericalString(int length)
        {
            string Chr = "abcedfghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var sb = new StringBuilder();
            for (int i = 1, loopTo = length; i <= loopTo; i++)
            {
                int idx = rand.Next(0, Chr.Length);
                sb.Append(Chr.Substring(idx, 1));
            }
            if (UsedStrings.Contains(sb.ToString()))
            {
                while (UsedStrings.Contains(sb.ToString()))
                {
                    sb.Clear();
                    for (int i = 1, loopTo1 = length; i <= loopTo1; i++)
                    {
                        int idx = rand.Next(0, Chr.Length);
                        sb.Append(Chr.Substring(idx, 1));
                    }
                }
            }
            UsedStrings.Add(sb.ToString());
            return sb.ToString();
        }
    }
}
