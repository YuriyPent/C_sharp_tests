using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Selenium
    {
    interface IWebDriver
        {
        void FindElement ();
        void SendKeys ( string keys );
        void Click ();

        }
    }
