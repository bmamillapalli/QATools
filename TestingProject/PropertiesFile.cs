using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingProject
{
    class PropertiesFile
    {
        enum PropertyType
        {
            ID,
            Name,
            ClassName,
            TagName,
            Xpath,
            CssSelector,
            LinkText,
            PartialLinkTest
        }

        public static IWebDriver Driver { get; set; }
    }
}
