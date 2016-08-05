using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.bing.com");
            driver.Manage().Window.Maximize();

            IWebElement searchInput = driver.FindElement(By.Id("sb_form_q"));
            searchInput.SendKeys("Hello World");
            searchInput.SendKeys(Keys.Enter);
        }
    }
}
