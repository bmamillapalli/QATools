using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using TestRoom.Environment;
using TestRoom.PageObjects;
using System.Threading;
using AutoItX3Lib;


namespace TestRoom.TestCases
{
    [TestFixture]
    class ActionClass
    {
        [SetUp]
        public void TestStart()
        {
            Console.WriteLine("Test Started");

            SetProperties.Driver = new ChromeDriver();
            SetProperties.Driver.Manage().Window.Maximize();
            //SetProperties.Driver.Navigate().GoToUrl("http://www.demoqa.com");
            SetProperties.Driver.Navigate().GoToUrl("https://www.google.com/imghp?hl=en&tab=wi&ei=Q0CIWJ64A8zbmAHx56_gBg&ved=0EKouCBcoAQ");

        }

        [Test]
        public void DemoQAExecution()
        {
            Console.WriteLine("Executing The Present TestCase");

            string ParentWindow = SetProperties.Driver.CurrentWindowHandle;
            Console.WriteLine(SetProperties.Driver.Title);

            SetProperties.Driver.FindElement(By.Id("qbi")).Click();
            SetProperties.Driver.FindElement(By.XPath(".//*[@id='qbug']/div/a")).Click();
            SetProperties.Driver.FindElement(By.Id("qbfile")).Click();


            //AutoItX3 autoItobj = new AutoItX3();

            //autoItobj.WinActivate("Open");
            //autoItobj.Send(@"E:\1.png");
            //autoItobj.Send("{ENTER}");

            try
            {
                Console.WriteLine("one");
                    try
                    {
                    Console.WriteLine("two");

                }
                catch (Exception)
                    {
                    Console.WriteLine("one");


                    throw;
                    }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("one");

                throw;
            }
        }

        [TearDown]
        public void TestEnd()
        {
            Console.WriteLine("Testing Is Done");
            Thread.Sleep(5000);
            SetProperties.Driver.Quit();
        }
    }
}
/* 
            TestingHomePage testingHomePage = new TestingHomePage();
            testingHomePage.LinkClicking();


            foreach (var window in SetProperties.Driver.WindowHandles)
            {
                SetProperties.Driver.SwitchTo().Window(window);
            }

            Console.WriteLine(SetProperties.Driver.Title);
            SetProperties.Driver.Close();

            SetProperties.Driver.SwitchTo().Window(ParentWindow);
            Console.WriteLine(SetProperties.Driver.Title);

            testingHomePage.NavigatePage();
            ContactPage contactPage = new ContactPage();
            contactPage.SendButton();

            IAlert popUp = SetProperties.Driver.SwitchTo().Alert();
            Assert.True(popUp.Text.Contains("empty"));

            
            popUp.Accept();
            Console.WriteLine(SetProperties.Driver.Title);

            SetProperties.TakeScreenShot("Screenshot");


            //IWebElement wait=new WebDriverWait(SetProperties.Driver, TimeSpan.FromMilliseconds(10000)).Until()
 
     */
