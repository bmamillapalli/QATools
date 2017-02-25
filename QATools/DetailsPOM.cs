using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace QATools
{
    class DetailsPOM
    {
        public DetailsPOM()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitle { get; set; }

        [FindsBy(How =How.Id,Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }
        
        public void EnterDetails(string title, string initials, string firstname,string middlename)
        {
            ddlTitle.SetDDLItems(title);
            txtInitial.SetInputItems(initials);
            txtFirstName.SetInputItems(firstname);
            txtMiddleName.SetInputItems(middlename);
            btnSave.SetClickingItems();


            SeleniumProperties.Driver.Navigate().Back();
            //SeleniumSetMethods.SetDDLItems(ddlTitle, title);
            //SeleniumSetMethods.SetInputItems(txtInitial, initials);
            //SeleniumSetMethods.SetInputItems(txtFirstName, firstname);
            //SeleniumSetMethods.SetInputItems(txtMiddleName, middlename);
            //SeleniumSetMethods.SetClickingItems(btnSave);


            //ddlTitle.SendKeys(title);
            //txtFirstName.SendKeys(firstname);
            //txtMiddleName.SendKeys(middlename);
            //btnSave.Click();
        }

    }
}
