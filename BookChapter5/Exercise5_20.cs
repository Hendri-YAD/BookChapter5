using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_20
    {
        public static void Main()
        {
            double[] employeeHour = new double[3];
            double grossPerHour = 7.0;

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Please enter the number of hours for employee {0}: ", i + 1);
                employeeHour[i] = Convert.ToDouble(Console.ReadLine());
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Employee {0} gross pay is {1}", i + 1, EffectiveHour(employeeHour[i]) * grossPerHour);
            }

        }

        static double EffectiveHour(double hour)
        {
            if (hour > 40)
                return 40 + (hour - 40) * 1.5;
            else
                return hour;
        }

    }
}
