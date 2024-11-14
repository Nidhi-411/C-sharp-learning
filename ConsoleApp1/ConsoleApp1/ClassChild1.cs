using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassChild1 : ConsoleApp1.Program // inheritence 
    {
        static void Main(String[] args)
        {   
            ClassChild1 c = new ClassChild1();
            Console.WriteLine("classchinl1 - consumig memebers of a class from it's parent class .  ");
            c.Test2();c.Test3();c.Test4();c.Test5();
            Console.ReadLine();
            // consumig memebers of a class from it's parent class in same project . 
        }
    }
}
