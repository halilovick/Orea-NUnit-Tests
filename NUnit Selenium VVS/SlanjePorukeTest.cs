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
public class SlanjePorukeTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();

        // Setting implicit wait to 10 seconds
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void testTestiranjeslanjaporuke()
    {
        driver.Navigate().GoToUrl("https://www.oreabazaar.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 823);

        // Waiting for the cookie consent banner to be present before clicking
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".cc-15e7")));

        driver.FindElement(By.CssSelector(".cc-15e7")).Click();

        // Adding a sleep for demonstration purposes, consider replacing it with a more specific wait
        Thread.Sleep(2000);

        js.ExecuteScript("window.scrollTo(0,700)");
    }
}
