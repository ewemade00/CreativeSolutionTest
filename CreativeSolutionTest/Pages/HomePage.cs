using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CreativeSolutionTest.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }



        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[1]/div[2]/button")]
        public IWebElement ViewDetailsOneBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[2]/div[2]/button")]
        public IWebElement ViewDetailsTwoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[3]/div[2]/button")]
        public IWebElement ViewDetailsThreeBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[2]/div/div/div[2]/p[1]")]
        public IWebElement UserOneName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[1]/div[2]/p[2]")]
        public IWebElement UserOnePhone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[1]/div[2]/p[1]")]
        public IWebElement UserOneEmailTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[2]/div[2]/p[1]")]
        public IWebElement UserTwoEmailTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/div[3]/div[2]/p[2]")]
        public IWebElement UserTwoPhoneTxt { get; set; }






        public void ClickViewDetailsButton_One()
        {
            ViewDetailsOneBtn.Clickly();

        }

        public void ClickViewDetailsButton_Two()
        {
            ViewDetailsTwoBtn.Clickly();

        }

        public void ClickViewDetailsButton_Three()
        {
            ViewDetailsThreeBtn.Clickly();


        }

        public void Verify_Userone_Name(string name)
        {

            Assert.AreEqual(UserOneName, name);

        }


        public void Verify_Userone_Phone(string phone)
        {

            Assert.AreEqual(UserOnePhone.Text, phone);

        }


        public void Verify_UserTwo_Phone_Email(string phone, string email)
        {

            Assert.AreEqual(UserTwoEmailTxt.Text, phone);
            Assert.AreEqual(UserTwoPhoneTxt.Text, email);


        }


    }



}
