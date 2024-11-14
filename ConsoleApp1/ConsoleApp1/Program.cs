using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program

    {
        private void Test1()
        {
            Console.WriteLine("private method");
        }
        internal void Test2()
        {
            Console.WriteLine("internal method ");
        }
        protected void Test3()
        {
            Console.WriteLine("protected method ");
        }
        public void Test4()
        {
            Console.WriteLine("public method");
        }
        protected internal void Test5()
        {
            Console.WriteLine("Protected internal");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            // Consuming memebers of a class from same class 

            p.Test1();p.Test2();p.Test3();p.Test4();p.Test5(); // every method is accesible within the class 

            Console.ReadLine();
        }
    }
}
