using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
    [TestFixture]
    public class PregledInformacijaTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void pregledInformacijaTest()
        {
            driver.Navigate().GoToUrl("https://www.oreabazaar.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.CssSelector(".mt-3")).Click();
            driver.FindElement(By.CssSelector(".mb-3:nth-child(1)")).SendKeys("bezveze@gmail.ba");
            driver.FindElement(By.CssSelector(".relative > .w-full")).SendKeys("passwordpassword");
            driver.FindElement(By.CssSelector(".mt-4")).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".relative:nth-child(1) > .nav-link"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".group:nth-child(1) a:nth-child(2) > .cursor-pointer"))).Click();
            {
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Profil")));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".relative:nth-child(1) > .nav-link"))).Click();
            {
                var element = driver.FindElement(By.CssSelector(".relative:nth-child(1) > .nav-link"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".group:nth-child(1) a:nth-child(2) > .cursor-pointer"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".px-8:nth-child(2) > button"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".border-2"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".border-gray-300"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".border-gray-300"))).SendKeys("lp");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".bg-green-500"))).Click();
        }
    }
