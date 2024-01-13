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
public class FiltriranjeprikazanihproizvodaTest {
  private IWebDriver driver;
  private WebDriverWait wait;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void filtriranjeprikazanihproizvoda() {
    driver.Navigate().GoToUrl("https://www.oreabazaar.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(785, 816);
    js.ExecuteScript("window.scrollTo(0,198.39999389648438)");
    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a:nth-child(2) .inset-0"))).Click();
    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".font-semibold"))).Click();
    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".mb-4:nth-child(1) li:nth-child(2)"))).Click();
    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".mb-4:nth-child(4) li:nth-child(4)"))).Click();
    js.ExecuteScript("window.scrollTo(0,2347.199951171875)");
    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".mx-2:nth-child(3)"))).Click();
    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".group:nth-child(3) a:nth-child(1) > .cursor-pointer"))).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
  }
}
