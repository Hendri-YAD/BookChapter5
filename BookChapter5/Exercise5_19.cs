using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_19
    {
        public static void Main()
        {
            double fixSal = 200;
            double commRate = 0.09;
            double sales = 0;

            Console.Write("Please enter the number of items: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Item {0} value is ", i);
                double val = Convert.ToDouble(Console.ReadLine());
                sales += val;                
            }

            double earnings = fixSal + commRate * sales;

            Console.WriteLine("The salesperson's earnings is {0:$0.00}", earnings);




        }
    }
}
