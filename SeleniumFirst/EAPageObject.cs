using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class EAPageObject
    {
        // Init driver in page factory
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // Operations on html elements on current page

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }        

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }



        // Other methods for out actions
        public void FillUserForm(string initial,  string firstName, string middleName)
        {
            txtInitial.EnterTextInTextBox(initial);
            txtFirstName.EnterTextInTextBox(firstName);
            txtMiddleName.EnterTextInTextBox(middleName);
            btnSave.Clicks();

            //SeleniumSetMethods.EnterTextInTextBox(txtInitial, initial);
            //SeleniumSetMethods.EnterTextInTextBox(txtFirstName, firstName);
            //SeleniumSetMethods.EnterTextInTextBox(txtMiddleName, middleName);
            //SeleniumSetMethods.Click(btnSave);




            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstName);
            //txtMiddleName.SendKeys(middleName);
            //btnSave.Click();
        }
    }
}
