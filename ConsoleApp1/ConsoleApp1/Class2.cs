using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// consuming members of a class from non-child class of same project 
namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" class1 - consumig memebers of a class from non-child class of same project ");
            Program p = new Program();
            p.Test2();p.Test4();p.Test5();
            Console.ReadLine();
        }
    }
}
