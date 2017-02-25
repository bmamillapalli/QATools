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
    class ContactPage
    {
        public ContactPage()
        {
            PageFactory.InitElements(UniversalProp.Driver, this);
        }

        [FindsBy(How=How.Id,Using = "submit_message")]
        IWebElement SendBtn { get; set; }

        public void SendButton()
        {
            SendBtn.ClickElement();
        }

    }
}
