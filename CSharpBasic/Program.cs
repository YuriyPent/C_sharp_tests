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
            GenericCollections();
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
        public static void GenericCollections()
        {
            string[] user1 = new string[] { "Karthik", "30", "kk@kk.com", "23121" };
            string[] user2 = new string[] { "Sam", "21", "sam@sam.com", "5214" };
            string[] user3 = new string[] { "Jacob", "27", "jacob@jacob.com", "9524" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);

            foreach (var value in dict)
            {
                string[] userInfo = value.Value;
                foreach (var user in userInfo)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}
