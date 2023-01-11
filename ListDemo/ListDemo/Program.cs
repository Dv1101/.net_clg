using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Customer
    {
        public int CustomerID { set; get; }
        public string CustomerName { set; get; }
    }
     class Program
    {
        static void Main(string[] args)
        {// these are generic one means what type u decide during decleration that only used 
            List<int> numbers = new List<int>() {12,45,67,88,90,21,88 };// here int only is used 
            numbers.Add(1000);//later on also u can add 
            List<string> cities = new List<string>() { "Hyderabad", "chennai", "delhi" };
            cities.Add("Vadodara");// later on also u can add 

            Console.WriteLine("\n displaying cities ..");
            foreach(string city in cities)
            {
                Console.WriteLine("{0}", city);
            }
            Console.WriteLine("\n displaying numbers ");
            foreach(int num in numbers)
            {
                Console.Write("{0,7}", num);
            }
            Console.WriteLine("\nenter number of customers ..");
            int noofcustomers = Convert.ToInt16(Console.ReadLine());
            List<Customer> clist = new List<Customer>();
            Console.WriteLine("enter customer details ..");
            for(int i=0;i<noofcustomers;i++)
            {
                Customer c = new Customer();
                Console.WriteLine("enter cusotmer {0} id:", i + 1);
                c.CustomerID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter customer {0} name :", i + 1);
                c.CustomerName = Console.ReadLine();
                clist.Add(c);
            }
            Console.WriteLine("\n Customer details printing");
            foreach(Customer cust in clist)
            {
                Console.WriteLine("{0}--{1}", cust.CustomerID, cust.CustomerName);
            }
            Console.ReadLine();
        }
    }
}

