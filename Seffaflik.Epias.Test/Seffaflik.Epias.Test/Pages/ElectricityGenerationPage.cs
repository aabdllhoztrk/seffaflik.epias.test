using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using seffaflik.epias.Pages;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seffaflik.Epias.Test.Pages
{
    public class ElectricityGenerationPage : BasePage
    {
        public ElectricityGenerationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement basTarih => FindElementById("j_idt230:date1_input");
        private IWebElement bitTarih => FindElementById("j_idt230:date2_input");
        private IWebElement btn_apply => FindElementByXPath("//span[text()='Uygula']");
        public IList<IWebElement> myList => Driver.FindElements(By.XPath("//DIV[@id='j_idt230:dt']//tr/td[3]")).ToList();


        public void enterDate(String startDate, String endDate)
        {
            sendKeys(basTarih, startDate);
            sendKeys(bitTarih, endDate);
            Click(btn_apply);
        }

        List<decimal> all_elements_text = new List<decimal>();
        public decimal GetGeneration(int i) 
        {
            var a = all_elements_text[i];
            return a;
        }                  
        public void AmountofGeneration()
        {
            for (int i = 0; i < myList.Count(); i++)
            {
                all_elements_text.Add(Convert.ToDecimal(myList[i].Text));
            }
        }
    }

}

