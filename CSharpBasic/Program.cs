using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testInts = new int[] { 101, 102, 103, 104, 105 };
            for (int i = 0; i < testInts.Length; i++)
                Console.WriteLine("The value of " + i + " is " + testInts[i]);

            string[] testNames = new string[] { "Login", "UserForm", "Selenium", "Hover" };
            foreach (var testName in testNames)
            {
                Console.WriteLine(testName);
            }

            Console.Read();
        }
    }
}
