using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingProject
{
    static class SetMethods
    {
        public static void SetTextbox(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        public static void SetRadiobtn(this IWebElement element)
        {
            element.Click();
        }
        public static void SetDropDownList(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);

        }
        public static void SetCheckbox(this IWebElement element)
        {
            element.Click();
        }
        public static void SetSubmit(this IWebElement element)
        {
            element.Submit();
        }

    }
}
