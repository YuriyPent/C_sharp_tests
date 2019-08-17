using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestClass1
    {
        private int i = 0;
        public void SetValue(int value)
        {
            i = value;
        }
        public void GetValue()
        {
            Console.WriteLine("The value of i is : " + i);
        }
        //Members
        public void TestCase1(string result)
        {
            Console.WriteLine("executing TestCase 1 "
                + result);
        }

        public void TestCase2(string result)
        {
            Console.WriteLine("executing TestCase 2 "
                + result);
        }

    }
}
