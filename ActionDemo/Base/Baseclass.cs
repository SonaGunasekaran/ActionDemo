using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ActionDemo.Base
{
    public class Baseclass
    {
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            //Maximize the browser window
            chromeOptions.AddArgument("start-maximized");
            //Disable the notifications
            chromeOptions.AddArgument("--disable-notifications");
            driver = new ChromeDriver(chromeOptions);
            driver = new ChromeDriver(chromeOptions);
            //Get the url
            driver.Url = "http://demo.guru99.com/test/drag_drop.html";
            System.Threading.Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            driver.Quit();
        }
    }
}
