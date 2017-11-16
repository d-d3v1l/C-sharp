using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumLiveDemo
{
    [TestClass]
    public class LiveDemoTests
    {
        private IWebDriver Driver;

        [TestInitialize]
        public void OpenBrowser()
        {
            this.Driver = new ChromeDriver();
        }
                 
                [TestMethod]
        public void TestMethod1()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
            var fristNameTextBox = Driver.FindElement(By.Id("name_3_firstname"));
            fristNameTextBox.SendKeys("Valid First Name");

            var registrationButton = Driver.FindElement(By.Id("menu-item-374"));

            string registrationButtonText = registrationButton.Text;

            Assert.AreEqual("Registration", registrationButtonText);

            Thread.Sleep(3000);
        }
        [testCleanup]
        public void CloseBrowser()
        {
        this.Driver.Close();
        }
    }
}
