using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers From 1 To 100 :");
            for(int i=1;i<100;i++)
            {
               int count = 0;
                if (i >= 1)
                {
                    for(int j=2;j<i;j++)
                    {
                        if(i%j == 0)
                            count=1;
                        break;

                    }
                    if (count == 0)
                    {
                        Console.Write(i+ " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
