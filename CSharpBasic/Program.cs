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
            // looping
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Printing number : " + i);
            }

            bool elementNotVisible = true;
            int mockNoOfSeconds = 0;
            while (elementNotVisible)
            {
                Console.WriteLine("No of seconds waiting " + mockNoOfSeconds);
                if (mockNoOfSeconds == 4)
                {
                    elementNotVisible = false;
                    mockNoOfSeconds++;
                }
                Console.Read();
            }
            //conditions
            string testCaseState = "INCONCLUSIVES";

            if (testCaseState == "PASSED")
                Console.WriteLine("The case PASSED");
            else if (testCaseState == "FAILED")
                Console.WriteLine("The case FAILED");
            else if (testCaseState == "INCONCLUSIVE")
                Console.WriteLine("The case INCONCLUSIVE");

            switch (testCaseState)
            {
                case "PASSED":
                    Console.WriteLine("The case PASSED");
                    break;
                case "FAILED":
                    Console.WriteLine("The case FAILED");
                    break;
                case "INCONCLUSIVE":
                    Console.WriteLine("The case INCONCLUSIVE");
                    break;

                default:
                    {
                        Console.WriteLine("The case is not the one you sent");
                        break;
                    }
            }
            Console.Read();
        }
    }
}
