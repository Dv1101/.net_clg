using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverlading
{
    class ABCD
    {
       public  int a;
        public ABCD()
        {

        }
        public ABCD(int k)
        {
            this.a = k;
        }
        public static ABCD operator+(ABCD obj1,ABCD obj2)
        {
            ABCD third = new ABCD();
            third.a = obj1.a + obj2.a;
            return third;
        }
 
    }
     class Program
    {
        static void Main(string[] args)
        {
            ABCD obj1 = new ABCD(10);// paramatized cnstructor called 10 is assigned to a of obj1
            ABCD obj2 = new ABCD(20);// again in obj2 a 20 is assigned using constructor
            ABCD obj3 = new ABCD();// here default is called and here a is empty not assigned 
            obj3 = obj1 + obj2; //here object cannot be added directly in obj3.a 30 will not go directly
            obj3.a = obj1.a + obj2.a;// this is okay but i want ditectly to be addded above 
            Console.WriteLine(obj3.a);//displaying..the third object
            Console.ReadLine();
        }
    }
}
