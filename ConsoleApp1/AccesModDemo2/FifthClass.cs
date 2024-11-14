using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModDemo2
{
    internal class FifthClass
    {
        static void Main(string[] args)
        {
            ConsoleApp1.Program p = new ConsoleApp1.Program();
            p.Test4(); // only public 
            Console.ReadLine();
            // // consuming members of a class from non-child class of different project 

        }
    }
}
