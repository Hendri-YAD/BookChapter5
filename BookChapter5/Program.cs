using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_6
    {
        static void Main(string[] args)
        {
            int sum=0, x=1;

            while(x < 11)
            {
                sum += x;
                x++;
            }

            Console.WriteLine( "The sum is: {0}"  , sum );

        }
    }
}
