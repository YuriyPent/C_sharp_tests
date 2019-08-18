using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestClass1
    {
        public void Add()
        {
            Console.WriteLine("This is empty Add method");
        }

        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("This is Add method : " + result);
        }
    }
}
