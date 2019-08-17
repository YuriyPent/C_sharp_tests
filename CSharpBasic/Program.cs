using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        //A label for the class program
        //Program p = new Program();
        static void Main(string[] args)
        {
            TestClass1 class1 = new TestClass1();
            class1.SetValue(20);
            class1.GetValue();
            //class1.TestCase1("PASS");
            //class1.TestCase2("FAILED");
            //Console.Write("Hello, world");
            TestClass1 class2 = new TestClass1();
            class2.SetValue(30);
            class2.GetValue();
            Console.Read();
        }
    }
}
