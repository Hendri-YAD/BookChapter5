using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    class Exercise5_29
    {
        public static void Main()
        {
            Console.Write("Please enter the size of the square: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string s = "*";

            if(size == 1)
            {
                Console.WriteLine(s);
            }
            else if (size < 20)
            {
                for(int i = 1;i <=size; i++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();

                for(int i = 2; i < size; i++)
                {
                    Console.Write(s);
                    for(int j = 2; j < size; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(" *");
                }

                for (int i = 1; i <= size; i++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            else
            {
                size = 20;
                for (int i = 1; i <= size; i++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();

                for (int i = 2; i < size; i++)
                {
                    Console.Write(s);
                    for (int j = 2; j < size; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(" *");
                }

                for (int i = 1; i <= size; i++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }


        }

    }
}
