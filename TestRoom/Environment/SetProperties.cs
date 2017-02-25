using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Drawing.Imaging;

namespace TestRoom.Environment
{
    enum Locators
    {
        Id,
        Name,
        ClassName,
        CssSelector,
        Custom,
        TagName,
        Xpath,
        LinkText,
        PartialLinkText
    }
    static class SetProperties
    {
        public static IWebDriver Driver { get; set; }
        public static IAlert PopUp { get; set; }
        //public static 

        public static void TakeScreenShot(string filename)
        {
            ITakesScreenshot picHandler = UniversalProp.Driver as ITakesScreenshot;
            Screenshot pic = picHandler.GetScreenshot();
            pic.SaveAsFile(@"C:\Users\brahm\documents\visual studio 2015\Projects\QATools\TestRoom\Pictures\" + filename + ".png", ImageFormat.Png);
        }
        public static void SetTxt(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void SetRbtn(this IWebElement element, string value)
        {
            element.Click();
        }
        public static void SetChkBtn(this IWebElement element, string value)
        {
            element.Click();
        }
        public static void SetDDList(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
        public static void SetSubmitBtn(this IWebElement element)
        {
            element.Submit();
        }
        public static void SetClick(this IWebElement element)
        {
            element.Click();
        }

    }
}
