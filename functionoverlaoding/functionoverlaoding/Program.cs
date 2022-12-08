using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionoverlaoding
{
    class abcd
    {
        public void add(int x, int y)
        {
            Console.WriteLine("The sum is {0}", (x + y));
        }

        public decimal add(int x, float k,decimal yy)
        {
            return (x + Convert.ToDecimal(k) + yy);
        }
        public double add(int x, decimal jj, double yy)
        {
            return (x + Convert.ToDouble(jj) + yy);
        }
    }
    class cde : abcd
    {
        public void add(int x,char c)
        {
            Console.WriteLine("The sum is {0}", (x + c));
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            cde cc = new cde();
            cc.add(10, 'A');
            cc.add(12, 45);
         Console.WriteLine("{0}",cc.add(12, 345.67M, 345.234));
         Console.WriteLine("{0}",cc.add(13, 45 / 67f, 45.678M));
            Console.ReadLine();
        }
    }
}
