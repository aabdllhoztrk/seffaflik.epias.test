using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace seffaflik.epias.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void navigatetoHomePage() 
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Window.Maximize();
            options.AddArguments("headless");
            driver.Url = "https://seffaflik.epias.com.tr/transparency/";
            
            
        }
    }
}
