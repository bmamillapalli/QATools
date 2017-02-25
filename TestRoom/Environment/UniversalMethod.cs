using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestRoom.Environment
{
    static class UniversalMethod
    {
        public static void TxtInput(this IWebElement element,string value)
        {
            element.SendKeys(value);
        }

        public static void Rbtn(this IWebElement element,string value)
        {
            element.Click();
        }
        public static void Chkbtn(this IWebElement element,string value)
        {
            element.Click();
        }
        public static void DDList(this IWebElement element,string value)
        {
            new SelectElement(element).SelectByText(value);
        }
        public static void Submitbtn(this IWebElement element)
        {
            element.Submit();
        }
        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }

    }
}
