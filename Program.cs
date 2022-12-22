using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int z = 0;
            Console.WriteLine("Please enter the start number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the end number");
            int n2 = int.Parse(Console.ReadLine());
            
            for (int i = n1; i <= n2; i++)
            {
                z = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        z += j; 

                }

                if (z == i)
                {
                    Console.WriteLine(i + " is perfect");
                }

            }

        }
    }
}
