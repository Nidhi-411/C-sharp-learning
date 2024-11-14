using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModDemo2
{     
    internal class Fourthclass : Program
    {
        static void Main(string[] args)
        {
            // consumig memebers of a class from it's parent class in different project 
            Fourthclass a = new Fourthclass();
            a.Test3();a.Test5();a.Test4(); // protected , protected internal , public 
            Console.ReadLine();

        }
    }
}
