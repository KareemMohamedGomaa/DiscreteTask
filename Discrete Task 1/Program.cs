using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Task_1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter n1:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter n2:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" The list of the prime numbers from n1 to n2 ");

            for (int x = n1; x <= n2; x++)
            {
                int y = 0;

                for (int z = 2; z <= x / 2; z++)
                {
                    if (x % z == 0)
                    {
                        y++;
                        break;
                    }
                }

                if (y == 0 && x!= 1 && x!=0)
                    Console.WriteLine(x);
            }
            Console.WriteLine();
        }
    }





    
             

            

         
         


        
    
}
