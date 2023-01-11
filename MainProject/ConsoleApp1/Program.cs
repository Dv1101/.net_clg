using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeFind;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindingCube obj = new FindingCube();
           Console.WriteLine("{0}",obj.Findcube(3));
            Console.ReadLine();
        }
    }
}
