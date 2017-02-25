using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace QATools
{
    static class SeleniumSetMethods
    {
        public static void SetInputItems(this IWebElement element, string value)
        {
                element.SendKeys(value);
        }
        public static void SetDDLItems(this IWebElement element, string value)
        {
                new SelectElement(element).SelectByText(value);
        }
        public static void SetClickingItems(this IWebElement element)
        {
            element.Click();

        }
        public static void SetSubmitItems(this IWebElement element)
        {
            element.Submit();
        }
    }
}
