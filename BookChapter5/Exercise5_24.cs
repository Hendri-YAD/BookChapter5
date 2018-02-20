using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookChapter5
{
    public class Mystery2
    {
        public static void Main(string[] args)
        {
            int count = 1;

            while (count <= 10)
            {
                Console.WriteLine(count % 2 == 1 ? "****" : "++++++++");
                ++count;
            } // end while
        } // end Main
    } // end class Mystery2
}
