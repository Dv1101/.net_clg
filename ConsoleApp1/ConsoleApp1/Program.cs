using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname, middlename, lastname;
            Console.WriteLine("enter firstname:");
            firstname = Console.ReadLine();
            Console.WriteLine("enter middle name");
            middlename = Console.ReadLine();
            Console.WriteLine("enter last name:");
            lastname = Console.ReadLine();
            string fullname = firstname + " " + middlename + " " + lastname;
            string fullname2 = string.Concat(firstname, " ", middlename, " ", lastname);
            Console.WriteLine("{0}", fullname);
            Console.WriteLine("{0}", fullname2.ToUpper());
            Console.WriteLine("enter new first name");
            string newfirstname = Console.ReadLine();
            Console.WriteLine("{0}", fullname.Replace(firstname, newfirstname));
            Console.WriteLine("extracting middle name ");
            Console.WriteLine("{0}", fullname.Substring(6,5));// kumar taking and printing
           Console.ReadLine();





        }
    }
}
