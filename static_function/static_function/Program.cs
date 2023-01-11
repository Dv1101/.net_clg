using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_function
{
    internal class Program
    {

        class abcd
        {
            public static int count = 0;

            public static void printcount()
            {
                abcd obj1 = new abcd();
                count++;//count is non static
                Console.WriteLine("The current calue is {0}", +count);
            }

            static void Main(string[] args)
            {
                printcount();
                Console.WriteLine();
            }
        }
    }
}
