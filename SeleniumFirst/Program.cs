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
            PropertiesCollection.driver = new ChromeDriver(@"C:\Users\Bradley\Programming\Selenium\");

            // Nav to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("Execute", "automation");

            pageEA.FillUserForm("Initial", "FirstName", "MidleName");

            

            //// Title drop down
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //// Initial text box
            //SeleniumSetMethods.EnterTextInTextBox("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //// Click Save button
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("In Test 2");
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
