using OpenQA.Selenium;
using ReteGivingHap.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReteGivingHap.PageObject
{
    class ContactUsPage
    {
        public IWebDriver driver;

        public ContactUsPage()
        {
            driver = BaseTest.driver;
        }




        private By ContactUs = By.CssSelector("#menu-item-591 > a");
        private By FirstName = By.CssSelector("#forminator-field-name-1"); 
        private By LastName = By.CssSelector("#forminator-field-name-2");
        private By Email = By.CssSelector("#forminator-field-email-1");
        private By Number = By.CssSelector("#forminator-field-phone-1");
        private By Subject = By.CssSelector("#forminator-field-text-1");
        private By YourMessage = By.CssSelector("#forminator-field-textarea-1");
        private By ClickAcceptcookies = By.CssSelector("#cmplz-cookiebanner-container > div > div.cmplz-buttons > button.cmplz-btn.cmplz-accept.cc-allow.cc-btn");
        private By ClickSend = By.CssSelector("#forminator-module-2208 > div.forminator-row.forminator-row-last > div > div > button");
        private By SuccessfullMessage = By.CssSelector("#forminator-module-2208 > div.forminator-response-message.forminator-show.forminator-success > p > b");



        public void ClickContactUs()
        {
            driver.FindElement(ContactUs).Click();
        }

        public void EnterFirstName(string name)
        {
            driver.FindElement(FirstName).SendKeys(name);
        }

        public void EnterLastName(string name)
        {
            driver.FindElement(LastName).SendKeys(name);
        }

        public void EnterEmailAddress(string email)
        {
            driver.FindElement(Email).SendKeys(email);
        }

        public void EnterPhoneNumber(string number)
        {
            driver.FindElement(Number).SendKeys(number);
        }

        public void EnterSubject(string subject)
        {
            driver.FindElement(Subject).SendKeys(subject);
        }

        public void EnterYourMessage(string yourmessage)
        {
            driver.FindElement(YourMessage).SendKeys(yourmessage);
        }

        public void ClickAcceptCookies()
        {
            driver.FindElement(ClickAcceptcookies).Click();
        }

        public void clickSend()
        {
            driver.FindElement(ClickSend).Click();
        }

        public bool ThenSuccessfullMessageDisplayed()
        {
            return driver.FindElement(SuccessfullMessage).Displayed;
        }

























    }
}
