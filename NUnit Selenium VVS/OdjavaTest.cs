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
[TestFixture]
public class OdjavaTest
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
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void testTestiranjeodjavesprofila()
    {
        driver.Navigate().GoToUrl("https://www.oreabazaar.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 823);
        driver.FindElement(By.CssSelector(".mt-2 > img")).Click();
        driver.FindElement(By.CssSelector(".border:nth-child(1) > .cursor-pointer")).Click();
    }
}
