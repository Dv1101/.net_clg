using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraysdemo
{
    class Customer
    {
        public int CustomerID { set; get; }
        public string CustomerName { set; get; }
    }
     class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[5] { 12, 45, 67, 8, 9 };// declaring and intilizing
            int[] a = new int[5];// only declaring 
            int i, j, sum = 0;
            Console.WriteLine("\nreading values in array ");
            for(i=0;i<a.Length;i++)  // here a is array name
            {
                Console.Write("enter [{0}] element:", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n printing the array..");
            for(i=0;i<a.Length;i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Console.WriteLine("\n printing the array using for each loop");
            foreach(int ele in a)// one one element i will take from a and put in ele and print
            {
                Console.Write("{0,4}", ele);
            }
            Console.WriteLine("\n sum of ellements calculating..");
            for(i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("The sum is {0}", sum);
            Console.WriteLine("\n enter the element to be searched in array ");
            int searchele = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<a.Length;i++)
            {
                if (a[i]==searchele)
                {
               Console.WriteLine("\nThe element {0} is found at {1} position", searchele, i + 1);
                }
            }
            Console.WriteLine("\n sorting the array now ..");
            for(i=0;i<a.Length-1;i++) //bubble sort trying here
            {
                for(j=i+1;j<a.Length;j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n printing array after sorting..");
            for(i=0;i<a.Length;i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Customer[] clist = new Customer[3];// declaring an customer array of 3 
            Console.WriteLine("\nenter the 3 customer details now..");
            for(i=0;i<3;i++)
            {
                Customer c = new Customer();
                Console.WriteLine("enter customer {0} id :", i + 1);
                c.CustomerID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter customer {0} name:", i + 1);
                c.CustomerName = Console.ReadLine();
                clist[i] = c;
            }
            Console.WriteLine("\n printing all 3 customers  u entered ..");
            foreach(Customer cust in clist)
            {
                Console.WriteLine("{0}--{1}", cust.CustomerID, cust.CustomerName);
            }
            Console.ReadLine();
        }
    }
}
