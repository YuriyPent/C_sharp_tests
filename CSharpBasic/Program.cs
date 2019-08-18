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

            //((UserListPage)loginPage).ClickButton();
            Console.Read();
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
