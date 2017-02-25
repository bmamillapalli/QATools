using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace QATools
{
    class LoginPOM
    {

        public LoginPOM()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);   
        }

        [FindsBy(How =How.Name,Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public DetailsPOM LoginDetails(string username,string password)
        {
            txtUserName.SetInputItems(username);
            txtPassword.SetInputItems(password);
            btnLogin.SetSubmitItems();

            //SeleniumSetMethods.SetInputItems(txtUserName, username);
            //SeleniumSetMethods.SetInputItems(txtPassword, password);
            //SeleniumSetMethods.SetSubmitItems(btnLogin);

            //txtUserName.SendKeys(username);
            //txtPassword.SendKeys(password);
            //btnLogin.Submit();

            return new DetailsPOM();
        }
    }
}
