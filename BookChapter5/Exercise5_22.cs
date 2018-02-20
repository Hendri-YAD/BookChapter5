using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_22
    {
        public static void Main()
        {
            Console.WriteLine("{0,-8} {1,-8} {2,-8} {3, -8}\n", "N", "10*N", "100*N", "1000*N");

            for(int i=1; i <= 5; i++)
            {
                Console.WriteLine("{0,-8} {1,-8} {2,-8} {3, -8}", i, 10*i, 100*i, 1000*i);                
            }
            




        }
    }
}
