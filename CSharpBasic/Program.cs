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

            //Delegate examples
            Printer p = DelegateTry.PrintValue_1;
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