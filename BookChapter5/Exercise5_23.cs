using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_23
    {
        public static void Main()
        {
            int[] arr = new int[10];

            for(int i = 0; i< 10; i++)
            {
                Console.Write("Please enter for number {0}: ", i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max1 = arr[0], max2 = arr[1];
            int counter1 = 0;

            for(int i = 0; i < 10; i++)
            {
                if (arr[i] > max1)
                {
                    counter1 = i;
                    max1 = arr[i];
                }
            }

            max1 = arr[counter1];

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] > max2 && i != counter1)
                    max2 = arr[i];
            }

            Console.WriteLine("The first biggest number is {0} and the second biggest number is {1}", max1, max2);

        }

        


    }
}
