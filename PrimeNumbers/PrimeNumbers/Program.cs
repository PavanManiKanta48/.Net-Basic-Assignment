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
            for(int i=2;i<=100;i++)
            {
              
                    bool isPrimeNumber = true;
                    for (int j=2;j<i;j++)
                    {
                        if(i%j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                        
                    }
                    if (isPrimeNumber)
                    {
                        Console.Write(i+ " ");
                    }
               
            }
            Console.ReadLine();
        }
    }
}
