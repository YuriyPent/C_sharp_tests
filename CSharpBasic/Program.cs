using CSharpBasic.Browsers;
using CSharpBasic.Delegates;
using CSharpBasic.ExtensionMethods;
using CSharpBasic.Selenium;
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

            //Console.WriteLine (GetBrowserName (Browser.IE));
            //IWebDriver driver = new Chrome ();
            //driver.FindElement ();
            //driver.SendKeysWithSpChar ("executeautomation", "!!!");
            //CollectionsExample.GenericCollectionsWithCustomClass ();

            //Delegate examples C#1.0
            //Printer p = DelegateTry.PrintValue_1;
            //p ("executeautomation");

            //Delegate examples C#2.0
            //Printer p = delegate ( string values )
            //    {
            //        Console.WriteLine ($"The value printed inline: {values}");
            //        };
            //p ("executeautomation");

            //Delegate examples C#3.0
            Printer p = ( values ) => { Console.WriteLine ($"The value printed from Lambda expression: {values}"); };
            p ("executeautomation");
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