using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using BoDi;

namespace CreativeSolutionTest
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly IObjectContainer _objecContainer;

        private IWebDriver _driver;

        public Hooks (IObjectContainer objectContainer)
        {

            _objecContainer = objectContainer;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _objecContainer.RegisterInstanceAs<IWebDriver>(_driver);


           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();

           
        }
    }
}

