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
            int result = class1.Add(2, 4);
            Console.WriteLine(result + 10);
            class1.Add();
            Console.Read();
        }

        private static void NewMethod()
        {

            //Implicit convertion
            Int16 salary = Int16.MaxValue;
            int salaryIncrement = salary;
            salaryIncrement = 3276745;
            Console.WriteLine("The salaryIncrement is : " + salaryIncrement);

            var incomeTax = 23234.234d;
            var incomeTax2 = "haha";

            Console.WriteLine("The incomeTax is : " + incomeTax.GetType().Name);
            Console.WriteLine("The incomeTax is : " + incomeTax2);

            var loginPage = new LoginPage();
            loginPage.ClickButton();
        }

        public class LoginPage
        {
            public string UserName { get; set; }

            public void ClickButton()
            {
            }
        }

        public class UserListPage
        {
            public string ListOfUsers { get; set; }

        }
    }
}
