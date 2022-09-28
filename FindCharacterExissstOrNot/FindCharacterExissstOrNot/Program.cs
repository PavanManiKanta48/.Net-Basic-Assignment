using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCharacterExissstOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a string : ");
            string name=Console.ReadLine();
            Console.Write("enter a 1 Character : ");
            char character = char.Parse(Console.ReadLine());
            Boolean result=name.Contains(character);
            Console.WriteLine($"Does string contain specified character? {result}");

        }
    }
}
