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
