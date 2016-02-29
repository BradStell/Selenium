using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // Page properties
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }


        // Page Actions

        // Login Action
        // Returns the next page (EAPageObject) to simulate browser navigation
        public EAPageObject Login(string userName, string password)
        {
            // Login

            // Username
            txtUserName.EnterTextInTextBox(userName);

            // Password
            txtPassword.EnterTextInTextBox(password);

            // Click Login button
            btnLogin.Clicks();

            // Return the next page object
            return new EAPageObject();
        }
    }
}
