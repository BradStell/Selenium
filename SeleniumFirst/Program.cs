using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        //// Create the reference for our browser
        //IWebDriver driver = new ChromeDriver(@"C:\Brad\");



        static void Main(string[] args) { }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\Brad\");

            // Nav to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Title drop down
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            // Initial text box
            SeleniumSetMethods.EnterTextInTextBox("Initial", "executeautomation", PropertyType.Name);

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            // Click Save button
            SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            // close browser
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed browser");
        }
    }
}
