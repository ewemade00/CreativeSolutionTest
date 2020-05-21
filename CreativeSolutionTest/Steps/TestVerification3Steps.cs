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
    public class TestVerification3Steps
    {
        private IWebDriver _driver;

        public TestVerification3Steps(IWebDriver driver)
        {
            _driver = driver;

        }



        [When(@"I click on usserthree view details buttons")]
        public void WhenIClickOnUsserthreeViewDetailsButtons()
        {

            HomePage hmpage = new HomePage(_driver);

            //Click on click to view details
            hmpage.ClickViewDetailsButton_Three();
            Thread.Sleep(5000);
        }
        
        [Then(@"I should be able to validate userthree details on the grids")]
        public void ThenIShouldBeAbleToValidateUserthreeDetailsOnTheGrids()
        {
            String additional_info = "Buys Lots of Products in general";

            //Validating user one details with page source
          

            //try
           // {

                Assert.IsTrue(_driver.FindElement(By.TagName("body")).Text.Contains(additional_info));
               // Console.Write("assertion page source Pass");

            //}

            //catch (Exception e)
            //{
               // Console.Write(e);

            //}

            //Console.Read();


        }
    }
}
