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
            Console.WriteLine("The int MinValue is : " + int.MinValue);
            Console.WriteLine("The int MaxValue is : " + int.MaxValue);
            Console.WriteLine("The Int16 MinValue is : " + Int16.MinValue);
            Console.WriteLine("The Int16 MaxValue is : " + Int16.MaxValue);
            Console.WriteLine("The Int32 MinValue is : " + Int32.MinValue);
            Console.WriteLine("The Int32 MaxValue is : " + Int32.MaxValue);
            Console.WriteLine("The Int64 MinValue is : " + Int64.MinValue);
            Console.WriteLine("The Int64 MaxValue is : " + Int64.MaxValue);
            Console.WriteLine("The double MinValue is : " + double.MinValue);
            Console.WriteLine("The double MaxValue is : " + double.MaxValue);
            Console.WriteLine("The Double MinValue is : " + Double.MinValue);
            Console.WriteLine("The Double MaxValue is : " + Double.MaxValue);
            Console.WriteLine("The float MinValue is : " + float.MinValue);
            Console.WriteLine("The float MaxValue is : " + float.MaxValue);
            //class1.SetValue(20);
            //class1.GetValue();
            //class1.TestCase1("PASS");
            //class1.TestCase2("FAILED");
            //Console.Write("Hello, world");
            //TestClass1 class2 = new TestClass1();
            //class2.SetValue(30);
            //class2.GetValue();
            Console.Read();
        }
    }
}
