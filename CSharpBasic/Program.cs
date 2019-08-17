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

            double incomeTax = 23234.234d;
            Console.WriteLine("The incomeTax is : " + (int)incomeTax);

            object loginPage = new LoginPage();

            ((UserListPage)loginPage).ClickButton();
            Console.Read();
        }

        public class LoginPage
        {
            public string UserName { get; set; }

        }

        public class UserListPage
        {
            public string ListOfUsers { get; set; }
            public void ClickButton()
            {

            }
        }
    }
}
