using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CreativeSolutionTest
{
    public static class CustomMethods
    {
        //Enter Text

        public static void EnterText(this IWebElement element, string value)
        {

            element.SendKeys(value);
        }


        //Click button or Checkbox option

        public static void Clickly(this IWebElement element)
        {

            element.Click();

        }

        //Selecting a drop down control
        public static void SelectDropDown(this IWebElement element, string value)


        {


            new SelectElement(element).SelectByValue(value);



        }


    


      



    }


}