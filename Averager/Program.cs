using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[] { 10, 18, 20, 45, 99 };


            int sum = 0;

         


            for (int i = 0; i < 5; i++)
            {
                sum += temp[i];

            }
            int x =0;
            int a = (sum / 5);
            for (int j = 0; j < 5; j++)
                
                { if (temp[j] > a)
                { x++; }
            }

                Console.WriteLine("The number of numbers above the average of " + a + " is: " + x);
                Console.ReadKey();
            
        }
    }
}
