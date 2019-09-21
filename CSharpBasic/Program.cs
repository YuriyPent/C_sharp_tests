using CSharpBasic.Browsers;
using CSharpBasic.Delegates;
using CSharpBasic.ExtensionMethods;
using CSharpBasic.Selenium;
using CSharpBasic.Sharp7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
    {

    enum Browser
        {
        Firefox,
        Chrome,
        IE,
        Safari
        }

    class Program
        {
        static void Main ( string[] args )
            {

            NewFeatures feature = new NewFeatures ();

            feature.GetStudentsInfoWithGrade (feature.student.First ());
            //Console.WriteLine (GetBrowserName (Browser.IE));
            //IWebDriver driver = new Chrome ();
            //driver.FindElement ();
            //driver.SendKeysWithSpChar ("executeautomation", "!!!");
            //CollectionsExample.GenericCollectionsWithCustomClass ();

            //      Delegate examples C#1.0
            //Printer p = DelegateTry.PrintValue_1;
            //p ("executeautomation");

            //      Delegate examples C#2.0
            //Printer p = delegate ( string values )
            //    {
            //        Console.WriteLine ($"The value printed inline: {values}");
            //        };
            //p ("executeautomation");

            //      Delegate examples C#3.0
            //Printer p = ( values ) => { Console.WriteLine ($"The value printed from Lambda expression: {values}"); };
            //p ("executeautomation");

            //      C#3.5
            //Func<string, string> p = delegate ( string values )
            //    {
            //        return values;
            //        };

            //Console.WriteLine ($"The value from Func<> delegates is: {p ("executeautomation")}");

            //Action<string> actionP = delegate ( string values )
            //    {
            //        Console.WriteLine ($"The value from Action<> is: {values}");
            //        };

            //Action<string> actionWithLambda = values =>
            //{
            //    Console.WriteLine ($"The value from Action<> Lambda is: {values}");
            //};

            //actionP ("executeautomation");
            //actionWithLambda ("executeautomation");

            Console.Read ();
            }

        public static string GetBrowserName ( Browser browser )
            {
            if (browser==Browser.Firefox)
                return "Firefox is opened";
            else if (browser==Browser.Chrome)
                return "Chrome is opened";
            else if (browser==Browser.Safari)
                return "Safari is opened";
            else
                return "IE is opened";
            }
        }
    }