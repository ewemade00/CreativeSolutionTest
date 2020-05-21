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
    public class TestVerificationSteps
    {
        private IWebDriver _driver;

        public TestVerificationSteps(IWebDriver driver)
        {
            _driver = driver;

        }



        [Given(@"I am on the homepage of azurewebsites")]
        public void GivenIAmOnTheHomepageOfAzurewebsites()
        {
            _driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist");
            _driver.Manage().Window.Maximize();


        }

        [When(@"I click on view details button")]
        public void WhenIClickOnViewDetailsButton()
        {

            HomePage hmpage = new HomePage(_driver);
            
            //Click on click to view details
            hmpage.ClickViewDetailsButton_One();
            Thread.Sleep(5000);
            
            //Validating user one sub menu item text
            Assert.AreEqual(hmpage.UserOneEmailTxt.Text, "jsmith@test.com");
            hmpage.Verify_Userone_Phone("0208092029");





        }

        [Then(@"I should be able to validate user details on the grid")]
        public void ThenIShouldBeAbleToValidateUserDetailsOnTheGrid()

        {

            HomePage hmpage = new HomePage(_driver);

           
            String name = "John Smith";
            String email = "jsmith@test.com";
            String city = "London";
            String country = "England";
            String organization = "Company 1";
            String job_profile = "Software Developer";



            //Validating page title
            Assert.AreEqual("Selenium Test", _driver.Title);

            //Validating user one details with page source
            Assert.IsTrue(_driver.FindElement(By.TagName("body")).Text.Contains(name));
            Assert.IsTrue(_driver.FindElement(By.TagName("body")).Text.Contains(email));
            Assert.IsTrue(_driver.FindElement(By.TagName("body")).Text.Contains(city));
            Assert.IsTrue(_driver.FindElement(By.TagName("body")).Text.Contains(country));
            Assert.IsTrue(_driver.FindElement(By.TagName("body")).Text.Contains(organization));
            Assert.IsTrue(_driver.FindElement(By.TagName("body")).Text.Contains(job_profile));
            Console.Write("assertion page source Pass");

            //Validating Additional info text is present
            var element = _driver.FindElement(By.XPath("//*[@id='root']/div/div/div[2]/div/div/div[2]/p[9]"));
            Assert.IsTrue(element.Displayed);

           


          


        }
    }

}