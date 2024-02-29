using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char userSign;
            string signs = "";
            int addingNumberForSigns = 1;
            int numberOfSign;

            Console.WriteLine("введите имя");
            name = Console.ReadLine();
            Console.WriteLine("введите символ");
            userSign = Console.ReadKey().KeyChar;

            numberOfSign = name.Length + addingNumberForSigns;

            for (int i = 0; i <= numberOfSign; i++)
            {
                signs += userSign;
            }

            Console.Clear();
            Console.WriteLine(signs);
            Console.WriteLine(userSign + name + userSign);
            Console.WriteLine(signs);
        }
    }
}
