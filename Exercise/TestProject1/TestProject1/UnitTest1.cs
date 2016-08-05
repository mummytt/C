using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace TestProject1
{
    [TestClass]        
    public class UnitTest1
    {
        string a;
        IWebDriver driver;
        IWebElement searchInput;

        [TestInitialize]
        public void get()
        {
            a = "https://www.google.com.vn/?gws_rd=ssl";
            driver = new FirefoxDriver();
        }

        //[TestCategory("Nightly")]
        //public void set()
        //{
            
        //}

        [TestMethod]
       

        [TestProperty("MyProperty1", "Big")]
        [TestProperty("MyProperty2", "Small")]

        public void Method1()
        {   
            driver.Navigate().GoToUrl(a);
            Console.WriteLine("hello");


        }

        public void Method2()
        {
            driver.Navigate().GoToUrl(a);
            searchInput = driver.FindElement(By.XPath("//input[@id='lst-ib']"));
            searchInput.SendKeys("Hello World");
            searchInput.SendKeys(Keys.Enter);
        }

        [TestCleanup]
        public void clean()
        {
            driver.Quit();
        }
    }

    
}
