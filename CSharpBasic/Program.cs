using System;
using System.Collections;
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
            NonGenericCollection();

            Console.Read();
        }
        public static void ArrayExample()
        {
            int[] testInts = new int[] { 101, 102, 103, 104, 105 };
            for (int i = 0; i < testInts.Length; i++)
                Console.WriteLine("The value of " + i + " is " + testInts[i]);

            string[] testNames = new string[] { "Login", "UserForm", "Selenium", "Hover" };
            foreach (var testName in testNames)
            {
                Console.WriteLine(testName);
            }
        }
        public static void NonGenericCollection()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "ea");
            table.Add("Password", "ea123");
            table.Add("Button", "Submit");

            foreach (var key in table.Keys)
            {
                Console.WriteLine("The value for " + key + " is : " + table[key]);
            }
        }
    }
}
