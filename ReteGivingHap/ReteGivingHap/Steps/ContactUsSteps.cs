using NUnit.Framework;
using OpenQA.Selenium;
using ReteGivingHap.Hooks;
using ReteGivingHap.PageObject;
using System;
using TechTalk.SpecFlow;

namespace ReteGivingHap.Steps
{
    [Binding]
    public class ContactUsSteps
    {
        public IWebDriver driver = BaseTest.driver;
        ContactUsPage _contactUsPage = new ContactUsPage();

        [Given(@"I navigate to Retegiving\.com")]
        public void GivenINavigateToRetegiving_Com()
        {
            driver.Navigate().GoToUrl(@"https://retegivingdev1.reteicons.com/");
        }

        [When(@"I click on Contact Us button")]
        public void WhenIClickOnContactUsButton()
        {
            _contactUsPage.ClickContactUs();
        }

        [When(@"I enter First Name ""(.*)""")]
        public void WhenIEnterFirstName(string name)
        {
            _contactUsPage.EnterFirstName(name);
        }

        [When(@"I enter Last Name ""(.*)""")]
        public void WhenIEnterLastName(string name)
        {
            _contactUsPage.EnterLastName(name);
        }

        [When(@"I enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            _contactUsPage.EnterEmailAddress(email);
        }


        [When(@"I enter Contact Number ""(.*)""")]
        public void WhenIEnterContactNumber(Decimal number)
        {
            _contactUsPage.EnterPhoneNumber("07768767469");
        }


        [When(@"I enter Subject ""(.*)""")]
        public void WhenIEnterSubject(string subject)
        {
            _contactUsPage.EnterSubject("Birthday");
        }

        [When(@"I enter Your Message ""(.*)""")]
        public void WhenIEnterYourMessage(string yourmessage)
        {
            _contactUsPage.EnterYourMessage("I need my birthday party superb");
        }

        [When(@"I click Accept Cookies")]
        public void WhenIClickAcceptCookies()
        {
            _contactUsPage.ClickAcceptCookies();
        }

        [When(@"I click on Send button")]
        public void WhenIClickOnSendButton()
        {
            _contactUsPage.clickSend();
        }

        [Then(@"the message ""(.*)"" is displayed on the page")]
        public void ThenTheMessageIsDisplayedOnThePage(string message)
        {
            Assert.IsTrue(_contactUsPage.ThenSuccessfullMessageDisplayed());
        }
    }
}
