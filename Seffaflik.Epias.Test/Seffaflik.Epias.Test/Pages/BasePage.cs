using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace seffaflik.epias.Pages
{
    public abstract class BasePage
    {
        public IWebDriver _driver;
        protected IWebDriver Driver => _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        

        public IWebElement FindElementByXPath(string element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                wait.IgnoreExceptionTypes();
                Driver.FindElement(By.XPath(element));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }

        }

        public IWebElement FindElementById(string element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }

        }
        public IWebElement FindElementByName(string element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }

        }

        public IWebElement FindElementByTagName(string element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.TagName(element)));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }

        }
        public void goToUrl(string url)
        {
            Driver.Url = url;
        }

        public void Click(IWebElement element) 
        {
            element.Click();
        }

        public String GetText(IWebElement element) 
        {
           return element.Text;
        }

        public void sendKeys(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }

    }
}
