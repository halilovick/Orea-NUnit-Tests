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
public class OmiljeneTrgovineTest
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
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
    }

    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void omiljeneTrgovineTest()
    {
        driver.Navigate().GoToUrl("https://www.oreabazaar.com/");

        driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);

        driver.FindElement(By.CssSelector(".mt-3")).Click();

        driver.FindElement(By.CssSelector(".mb-3:nth-child(1)")).Click();

        driver.FindElement(By.CssSelector(".mb-3:nth-child(1)")).SendKeys("kerim@gmail.com");

        driver.FindElement(By.CssSelector(".relative > .w-full")).SendKeys("password");

        driver.FindElement(By.CssSelector(".mt-4")).Click();

        js.ExecuteScript("window.scrollTo(0,392.79998779296875)");

        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".group:nth-child(3) .h-\\[20vh\\]")));

        driver.FindElement(By.CssSelector(".group:nth-child(3) .h-\\[20vh\\]")).Click();

        js.ExecuteScript("window.scrollTo(0,0)");

        driver.FindElement(By.CssSelector(".text-gray-500")).Click();

        driver.FindElement(By.CssSelector(".text-gray-500")).Click();

        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".cursor-pointer > img")));
        driver.FindElement(By.CssSelector(".cursor-pointer > img")).Click();

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        {
            var element = driver.FindElement(By.LinkText("Profil"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }

        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }

        driver.FindElement(By.CssSelector(".flex:nth-child(1) > a > .mx-auto")).Click();

        driver.FindElement(By.CssSelector(".flex:nth-child(4) > button")).Click();

        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".cursor-pointer > img")));
        driver.FindElement(By.CssSelector(".cursor-pointer > img")).Click();

        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://www.oreabazaar.com/shop/695/baby-land-"));

        Assert.AreEqual("Baby Land | OREA", driver.Title);
    }
}
