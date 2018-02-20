using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    public class Mystery3
    {
        public static void Main(string[] args)
        {
            int row = 10;
            int column;

            while (row >= 1)
            {
                column = 1;

                while (column <= 10)
                {
                    Console.Write(row % 2 == 1 ? "<" : ">");
                    ++column;
                } // end while

                --row;
                Console.WriteLine();
            } // end while
        } // end Main
    } // end class Mystery3
}
