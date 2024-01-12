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
public class RegistracijanalogaTest
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
    public void registracijaNalogaTest()
    {
        driver.Navigate().GoToUrl("https://www.oreabazaar.com/");

        driver.Manage().Window.Size = new System.Drawing.Size(1372, 816);

        driver.FindElement(By.CssSelector(".mt-3")).Click();

        driver.FindElement(By.CssSelector(".m-8")).Click();

        driver.FindElement(By.CssSelector(".mx-auto > .mb-3:nth-child(1)")).Click();

        driver.FindElement(By.CssSelector(".mx-auto > .mb-3:nth-child(1)")).SendKeys("ProbaProbaProba");

        driver.FindElement(By.CssSelector(".mb-3:nth-child(2)")).SendKeys("ProbaProbaProba");

        driver.FindElement(By.CssSelector(".mb-3:nth-child(3)")).SendKeys("proba1111111222@gmail.com");

        driver.FindElement(By.CssSelector(".relative > .mb-3")).SendKeys("password");

        driver.FindElement(By.CssSelector(".h-5")).Click();

        driver.FindElement(By.CssSelector(".mt-4")).Click();
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://www.oreabazaar.com/"));

        Assert.AreEqual("Misli unikatno. Kupuj lokalno. | OREA", driver.Title);
    }
}
