using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace factorialusingforloop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // program to find x to the power of y
            int x, y;
            int i;
            Console.WriteLine("enter values in x and y");
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt16(Console.ReadLine());
            int pow = 1;
            for(i=1;i<=y;i++)
            {
                pow = pow * x;
            }
            Console.WriteLine("The {0} to the power of {1} is {2}", x, y, pow);
            Console.WriteLine("\n enter the number to find its table");
            int num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("{0} x {1}= {2}", num, i, num * i);
            }
            Console.ReadLine();

        }
    }
}
