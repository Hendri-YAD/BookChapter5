using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_38
    {
        public static void Main()
        {
            Console.Write("Please enter a value: ");
            int num = Convert.ToInt32(Console.ReadLine());

            double eComp = Math.Pow(Math.E, 1);

            double eCalc=1;
            int count = 1;        

            while(count <= num)
            {
                eCalc = eCalc + (1 / factorial(count));
                count++;
            }

            Console.WriteLine("Calculated value is {0} and Computer value is {1}", eCalc, eComp);

        }

        public static double factorial(int num)
        {
            if (num == 1)
                return num;
            else
                return num * factorial(num - 1);
        }
    }
}
