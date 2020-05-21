using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CreativeSolutionTest.Pages;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CreativeSolutionTest
{
    [Binding]
    public class TestVerification2Steps
    {

        private IWebDriver _driver;

        public TestVerification2Steps(IWebDriver driver)
        {
            _driver = driver;

        }

        [When(@"I click on ussertwo view details buttons")]
        public void WhenIClickOnUssertwoViewDetailsButtons()
        {
            HomePage hmpage = new HomePage(_driver);

            //Click on click to view details
            hmpage.ClickViewDetailsButton_Two();
            Thread.Sleep(5000);
        }

        [Then(@"I should be able to validate usertwo details on the grids")]
        public void ThenIShouldBeAbleToValidateUsertwoDetailsOnTheGrids()
        {
            HomePage hmpage = new HomePage(_driver);
            hmpage.Verify_UserTwo_Phone_Email("abcd@test.com", "01403 215100");

        }
    }
}