using System;
using AccessDemo1;

namespace newProgram{

public class Class1:Program
{
	public Class1()
	{
		Console.WriteLine("I am inside the child class");
	}
    static void Main(string[] args)
    {      Class1 c1 -new Class1();
            c1.Test1();c1.Test2();
       // p.Test1(); p.Test2(); p.Test3(); p.Test4(); p.Test5(); // every method is accesible within the class 

        Console.ReadLine();
    }
}
}