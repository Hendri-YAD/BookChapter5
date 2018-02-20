using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_41
    {
        public static void Main()
        {
            Console.Write("Please enter a four digit integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] fourDigits = new int[4];

            fourDigits[0] = num / 1000;
            fourDigits[1] = (num / 100) % 10;
            fourDigits[2] = (num / 10) % 10;
            fourDigits[3] = num % 10;


            for(int i = 0; i < 4; i++)
            {
                Console.Write("{0} ",fourDigits[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                fourDigits[i] += 7;
                fourDigits[i] %= 10;
            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", fourDigits[i]);
            }

            Console.WriteLine();

            int temp = fourDigits[0];
            fourDigits[0] = fourDigits[2];
            fourDigits[2] = temp;

            temp = fourDigits[1];
            fourDigits[1] = fourDigits[3];
            fourDigits[3] = temp;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", fourDigits[i]);
            }

            Console.WriteLine();

            string digs = fourDigits[0].ToString();
            digs = digs + fourDigits[1].ToString();
            digs = digs + fourDigits[2].ToString();
            digs = digs + fourDigits[3].ToString();

            Console.WriteLine(digs);

            int encrNum = Convert.ToInt32(digs);
            Console.WriteLine("{0:0000}", encrNum);

            Console.WriteLine("Reverse back is {0}", Reverse(encrNum));

        }


        public static int Reverse(int num)
        {
            int[] fourDigits = new int[4];

            fourDigits[0] = num / 1000;
            fourDigits[1] = (num / 100) % 10;
            fourDigits[2] = (num / 10) % 10;
            fourDigits[3] = num % 10;

            int temp = fourDigits[0];
            fourDigits[0] = fourDigits[2];
            fourDigits[2] = temp;

            temp = fourDigits[1];
            fourDigits[1] = fourDigits[3];
            fourDigits[3] = temp;

            for (int i = 0; i < 4; i++)
            {
                if (fourDigits[i] >= 7 && fourDigits[i] <= 9)
                    fourDigits[i] -= 7;
                else
                    fourDigits[i] = fourDigits[i] + 3;

                

            }

            string digs = fourDigits[0].ToString();
            digs = digs + fourDigits[1].ToString();
            digs = digs + fourDigits[2].ToString();
            digs = digs + fourDigits[3].ToString();

            Console.WriteLine(digs);

            int reverseNum = Convert.ToInt32(digs);
            return reverseNum;
        }

    }
}
