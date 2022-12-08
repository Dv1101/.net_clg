using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class calculator
    {
        public void add(int x, int y)
        {
            Console.WriteLine("The sum is {0}", (x + y));
        }
        public int substract(int x, int y)
        {
            int c;
            c = x - y;
            return c;
        }
    }
     class Program
    {
        
        static void Main(string[] args)
        {
            calculator pp = new calculator();
            pp.add(12, 4);
            int substractionresult = pp.substract(12, 6);
            Console.WriteLine("The substraction is {0}", substractionresult);
            // or like this also u can print
            Console.WriteLine("The substraction is {0}", pp.substract(12, 7));
            Console.ReadLine();


        }
    }
}
