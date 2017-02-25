using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using TestRoom.Environment;

namespace TestRoom.PageObjects
{
    class TestingHomePage
    {
        public TestingHomePage()
        {
            PageFactory.InitElements(UniversalProp.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "footer_term")]
        public IWebElement termLink { get; set; }

        [FindsBy(How =How.Name,Using = "nav_contact")]
        IWebElement contactLink { get; set; }

        public void LinkClicking()
        {
            termLink.ClickElement();
        }
        public void NavigatePage()
        {
            contactLink.ClickElement();
        }
    }
}
