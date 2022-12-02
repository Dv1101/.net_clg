using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using switch inside a do while loop
            int a, b, c, choice;
            Console.WriteLine("enter values in a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("1.Addtion..");
                Console.WriteLine("2.substraction..");
                Console.WriteLine("3.Multiplication..");
                Console.WriteLine("4.division..");
                Console.WriteLine("enter choice..");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:c = a + b;
                        Console.WriteLine("The sum is {0}", c);
                        break;
                    case 2: c = a -b;
                        Console.WriteLine("The subtraction is {0}", c);
                        break;
                    case 3:  c = a * b;
                        Console.WriteLine("The multiplication is {0}", c);
                        break;
                    case 4:   c = a / b;
                        Console.WriteLine("The sum is {0}", c);
                        break;
                    default:Console.WriteLine("dont enter other than 1 to 4 here values");
                        break;
                }
                Console.WriteLine("do u want to continue the menu ");
                if(Console.ReadLine()!="y")
                {
                    break;
                }


            } while (true);

            Console.ReadLine();
        }
    }
}