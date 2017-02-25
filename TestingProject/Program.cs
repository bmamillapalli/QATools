using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace TestingProject
{
    class Program
    {

        [SetUp]
        public void Initializer()
        {
            PropertiesFile.Driver = new ChromeDriver();
            PropertiesFile.Driver.Manage().Window.Maximize();
            PropertiesFile.Driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp/");

            Console.WriteLine("Testing Started");
        }

        [Test]
        public void TrialExecution()
        {

           
            Console.WriteLine("Testing");

        }

        [TearDown]
        public void TestingDone()
        {
            PropertiesFile.Driver.Close();
            Console.WriteLine("Done Testing");
        }
        static void Main(string[] args)
        {
        }
    }
}

/************************************************************************************************

           //Thread.Sleep(3000);

           //List<string> hobbies = new List<string>() { "dance", "reading" };
           //DetailsPOM obj = new DetailsPOM();

           //obj.Resgister("abcdef", "zyxwvu", "single", hobbies, "India", "11", "23", "1992", "1234567890", "window123", "window123@gmail.com", "I am very smart and very dum \n at same time", "Pass@word", "Pass@word");


           //// Storing Title name in String variable
           //String Title = PropertiesFile.Driver.Title;

           //// Storing Title length in Int variable
           //int TitleLength = PropertiesFile.Driver.Title.Length;

           //// Printing Title name on Console
           //Console.WriteLine("Title of the page is : " + Title);

           //// Printing Title length on console
           //Console.WriteLine("Length of the Title is : " + TitleLength);

           //// Storing URL in String variable
           //String PageURL = PropertiesFile.Driver.Url;

           //// Storing URL length in Int variable
           //int URLLength = PageURL.Length;

           //// Printing URL on Console
           //Console.WriteLine("URL of the page is : " + PageURL);

           //// Printing URL length on console
           //Console.WriteLine("Length of the URL is : " + URLLength);

           //// Storing Page Source in String variable
           //String PageSource = PropertiesFile.Driver.PageSource;

           //// Storing Page Source length in Int variable
           //int PageSourceLength = PropertiesFile.Driver.PageSource.Length;

           //// Printing Page Source on console
           //Console.WriteLine("Page Source of the page is : " + PageSource);

           //// Printing Page SOurce length on console
           //Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

           ***********************************************************************************************/

