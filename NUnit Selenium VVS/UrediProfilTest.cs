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
public class UrediProfilTest
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
    public void urediProfilTest()
    {
        var surname = "ProbaSurname";
        driver.Navigate().GoToUrl("https://www.oreabazaar.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
        {
            var element = driver.FindElement(By.CssSelector(".mt-3"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        driver.FindElement(By.CssSelector(".mt-3")).Click();
        driver.FindElement(By.CssSelector(".mb-3:nth-child(1)")).Click();
        driver.FindElement(By.CssSelector(".mb-3:nth-child(1)")).SendKeys("kerim@gmail.com");
        driver.FindElement(By.CssSelector(".relative > .w-full")).SendKeys("password");
        driver.FindElement(By.CssSelector(".mt-4")).Click();
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://www.oreabazaar.com/"));
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
        {
            var element = driver.FindElement(By.CssSelector(".flex:nth-child(1) > a > .mx-auto"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        driver.FindElement(By.CssSelector(".flex:nth-child(1) > a > .mx-auto")).Click();
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Profil")));
            var element = driver.FindElement(By.LinkText("Profil"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".m-4")));
        driver.FindElement(By.CssSelector(".m-4")).Click();
        {
            var element = driver.FindElement(By.CssSelector(".flex > .w-full:nth-child(2)"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).ClickAndHold().Perform();
        }
        {
            var element = driver.FindElement(By.CssSelector(".flex > .w-full:nth-child(2)"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.CssSelector(".flex > .w-full:nth-child(2)"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Release().Perform();
        }
        driver.FindElement(By.CssSelector(".flex > .w-full:nth-child(2)")).Click();
        driver.FindElement(By.CssSelector(".sm\\3Aw-\\[85vh\\] > .flex:nth-child(1)")).Click();
        driver.FindElement(By.Id("surname")).Clear();
        driver.FindElement(By.Id("surname")).SendKeys(surname);
        driver.FindElement(By.CssSelector(".flex-col > .flex:nth-child(2) > .mb-1")).Click();
        driver.FindElement(By.Id("gender")).Click();
        {
            var dropdown = driver.FindElement(By.Id("gender"));
            dropdown.FindElement(By.XPath("//option[. = 'Žensko']")).Click();
        }
        {
            var element = driver.FindElement(By.CssSelector(".py-10 > div"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).ClickAndHold().Perform();
        }
        {
            var element = driver.FindElement(By.CssSelector(".py-10 > div"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.CssSelector(".py-10 > div"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Release().Perform();
        }
        driver.FindElement(By.CssSelector(".py-10 > div")).Click();
        driver.FindElement(By.Id("day")).SendKeys("15");
        {
            var element = driver.FindElement(By.Id("day"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).ClickAndHold().Perform();
        }
        {
            var element = driver.FindElement(By.Id("day"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.Id("day"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Release().Perform();
        }
        driver.FindElement(By.CssSelector(".sm\\3A flex")).Click();
        driver.FindElement(By.Id("month")).SendKeys("5");
        driver.FindElement(By.Id("year")).Click();
        {
            var dropdown = driver.FindElement(By.Id("year"));
            dropdown.FindElement(By.XPath("//option[. = '1999']")).Click();
        }
        driver.FindElement(By.CssSelector(".py-5")).Click();


        driver.Navigate().GoToUrl("https://www.oreabazaar.com/user");

        wait.Until(driver =>
        {
            var el = driver.FindElement(By.CssSelector(".text-3xl"));
            return el.Displayed && !string.IsNullOrEmpty(el.Text);
        });

        Assert.AreEqual("Kerim " + surname, driver.FindElement(By.CssSelector(".text-3xl")).Text);
    }
}
