using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace QATools
{
    class FirstTestCase
    {
        [SetUp]
        public void Initialize()
        {


            //Initialize
            SeleniumProperties.Driver = new ChromeDriver();

            SeleniumProperties.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            Console.WriteLine("Start The Test");
        }

        [Test]
        public void Execution()
        {
            ExcelLib.PopulateInCollection(@"E:\TestingData.xlsx");

            LoginPOM LPOMobj = new LoginPOM();

            DetailsPOM POMobj = LPOMobj.LoginDetails(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

            //POMobj.EnterDetails("Mr.", "S", "Sai Mamillapalli", "Kowsik");
            POMobj.EnterDetails(ExcelLib.ReadData(1, "Title"), ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "FirstName"), ExcelLib.ReadData(1, "MiddleName"));

            Console.WriteLine("Running Test");
        }

        [TearDown]
        public void Clean()
        {
            SeleniumProperties.Driver.Close();

            Console.WriteLine("Testing Done");
        }

        //Main Method
        static void Main(string[] args)
        {

        }
    }
}
/*
driver.Url = "http://demoqa.com";
driver.Close();
*/
