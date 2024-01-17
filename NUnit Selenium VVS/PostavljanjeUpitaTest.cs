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

    internal class PostavljanjeUpitaTest
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
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void postavljanjeUpita()
        {
            driver.Navigate().GoToUrl("https://www.oreabazaar.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            driver.FindElement(By.CssSelector(".mt-3")).Click();
            driver.FindElement(By.CssSelector(".mb-3:nth-child(1)")).SendKeys("bezveze@gmail.ba");
            driver.FindElement(By.CssSelector(".relative > .w-full")).SendKeys("passwordpassword");
            driver.FindElement(By.CssSelector(".mt-4")).Click();
            js.ExecuteScript("window.scrollTo(0,600)");
            js.ExecuteScript("window.scrollTo(0,2048.800048828125)");
            driver.FindElement(By.CssSelector(".mb-6:nth-child(3) .mb-1:nth-child(7) > a")).Click();
            js.ExecuteScript("window.scrollTo(0,0)");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".mx-auto > .m-1\\.5:nth-child(1) > .mb-1"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("name-surname"))).SendKeys("Nobody Nobodyijanovic");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email"))).SendKeys("bezveze@gmail.hr");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("phoneNumber"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("phoneNumber"))).SendKeys("no");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-1\\.5:nth-child(3) > .mb-1"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("title"))).SendKeys("Pozdrav");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-1\\.5:nth-child(4) > .mb-1"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("message"))).SendKeys("Pozdrav");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-4"))).Click();
            driver.Close();
        }
    }
