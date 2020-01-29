using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium_app
{
    class Program
    {

        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://www.google.com");
            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("avion");

        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened");

        }
        
        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("avion");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }


    }
}
