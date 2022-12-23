using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter n1:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter n2:");
            int n2 = int.Parse(Console.ReadLine());

            int sum=0;

            Console.WriteLine(" The list of perfect numbers from n1 to n2 ");

            for (int x = n1; x < n2; x++)
            {

                int z = 1;
                sum = 0;
                while (z < x)
                {
                    if (x % z == 0)
                        sum = sum + z;
                    z++;
                }
                if (sum == x)
                    if (x != 0)

                        Console.WriteLine(x);
            }
            Console.WriteLine();

        }
    }

}
            
