using OpenQA.Selenium;
using seffaflik.epias.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seffaflik.Epias.Test.Pages
{
    public class ElectricityConsumptionPage : BasePage


    {
        public IWebDriver idriver;

        public ElectricityConsumptionPage(IWebDriver driver) : base(driver)
        {
            idriver=driver;
        }

        /// <summary>
        /// Tarih Locators
        /// </summary>
        private IWebElement basTarih => FindElementById("j_idt230:date1_input");
        private IWebElement bitTarih => FindElementById("j_idt230:date2_input");
        private IWebElement btn_apply => FindElementByXPath("//span[text()='Uygula']");
        private IWebElement btn_saat => FindElementByXPath("//span[text()='Saat']");
        IList<IWebElement> webElements => Driver.FindElements(By.XPath("//DIV[@id='j_idt230:dt']//tr/td[3]")).ToList();
        IList<IWebElement> times => Driver.FindElements(By.XPath("//DIV[@id='j_idt230:dt']//tr/td[2]")).ToList();


        public void enterDate(String startDate, String endDate)
        {
            sendKeys(basTarih, startDate);
            sendKeys(bitTarih, endDate);
            btn_saat.Click();
            Click(btn_apply);
        }   
        public decimal GetConsumption(int i)
        {
            var a = Convert.ToDecimal(webElements[i].Text);
            return a;
        }

        public String getTimes(int i)
        {
            var a = times[i].Text;
            return a;
        }
    }
}
