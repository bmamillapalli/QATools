using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QATools
{
    class SeleniumGetMethods
    {
        public static string GetInputValues(IWebElement element)
        {
                return element.Text;
        }
        public static string GetDDLValues(IWebElement element)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }
    }
}
