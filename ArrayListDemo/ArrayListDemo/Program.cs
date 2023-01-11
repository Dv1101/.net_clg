using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayListDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();// non generic it can store any value ..
            obj.Add('A');// storing characters 
            obj.Add("ravi"); // adding strings
            obj.Add(true); // adding boolean value 
            obj.Add(123.56);//decimal value adding
            Console.WriteLine("The number of elements in array is {0}", obj.Count);
            foreach(var ele in obj)// use var only becasue obj is having different kinds of types 
            {                       // inside it ...
                Console.WriteLine("{0}", ele);
            }
            Console.WriteLine("\n adding another 3 elements ");
            for (int i = 0; i < 3; i++)
            {
                obj.Add(Console.ReadLine());
            }
            Console.WriteLine("The number of elements in array now is {0}", obj.Count);
            foreach (var ele in obj)// use var only becasue obj is having different kinds of types 
            {                       // inside it ...
                Console.WriteLine("{0}", ele);
            }
            Console.WriteLine("\n adding an array of names to obj");
            string[] names = new string[3] { "rajiv", "suman", "kiran" };
            obj.AddRange(names);
            Console.WriteLine("The number of elements in array now is {0}", obj.Count);
            foreach (var ele in obj)// use var only becasue obj is having different kinds of types 
            {                       // inside it ...
                Console.WriteLine("{0}", ele);
            }
            obj.Reverse();
            Console.WriteLine("\n whole array reveresed ");
            Console.WriteLine("The reverseing of array now has  {0} elements", obj.Count);
            foreach (var ele in obj) 
            {                       
                Console.WriteLine("{0}", ele);
            }
            obj.Insert(0,"addingfirst");// adding at the first position
            Console.WriteLine("The number of elements in array now is {0}", obj.Count);
            foreach (var ele in obj) 
            {                      
                Console.WriteLine("{0}", ele);
            }
            obj.RemoveAt(2);// removing third element 
            Console.WriteLine("The number of elements in array now is {0}", obj.Count);
            foreach (var ele in obj)// use var only becasue obj is having different kinds of types 
            {                       // inside it ...
                Console.WriteLine("{0}", ele);
            }

            Console.ReadLine();
        }
    }
}
