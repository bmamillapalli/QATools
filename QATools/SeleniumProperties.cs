using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QATools
{
    enum PropertyTypes
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    class SeleniumProperties
    {
        public static IWebDriver Driver { get; set; }
    }
}
