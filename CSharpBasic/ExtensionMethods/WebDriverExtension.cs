using CSharpBasic.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasic.Selenium;

namespace CSharpBasic.ExtensionMethods
    {
    public static class WebDriverExtension
        {
        public static void SendKeysWithSpChar ( this IWebDriver driver,
                string keys,
                string spchar )
            {
            driver.SendKeys (keys);
            driver.SendKeys (spchar);
            }
        }
    }
