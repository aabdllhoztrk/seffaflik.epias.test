using OpenQA.Selenium;
using seffaflik.epias.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seffaflik.Epias.Test.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// electricity Production Selectors
        /// </summary>
        private IWebElement btn_electricityProduction => FindElementByXPath("//*[text()=' ELEKTRİK ÜRETİM']");
        private IWebElement btn_actualProduction => FindElementByXPath("//*[text()='  Gerçekleşen Üretim']");
        private IWebElement btn_realTimeProduction => FindElementByXPath("(//*[text()=' Gerçek Zamanlı Üretim'])[1]");
        private IWebElement btn_closeinfo => FindElementByXPath("(//SPAN[@class='ui-icon ui-icon-closethick'])[1]");
        

        /// <summary>
        /// electricity Consuption Selectors
        /// </summary>
        private IWebElement btn_electricityConsuption => FindElementByXPath("//*[text()=' ELEKTRİK TÜKETİM']");
        private IWebElement btn_actualConsuption => FindElementByXPath("//*[text()='  Gerçekleşen Tüketim']");
        private IWebElement btn_realTimeConsuption => FindElementByXPath("(//*[text()=' Gerçek Zamanlı Tüketim'])[1]");


        public ElectricityGenerationPage LocatetoElectricityGenarationPage() 
        {
            //Click(btn_closeinfo);
            Click(btn_electricityProduction);
            Click(btn_actualProduction);
            Click(btn_realTimeProduction);
            Thread.Sleep(5000);
            return new ElectricityGenerationPage(Driver);
        }

        public ElectricityConsumptionPage LocatetoElectricityConsumptionPage()
        {
            Click(btn_electricityConsuption);
            Click(btn_actualConsuption);
            Click(btn_realTimeConsuption);
            Thread.Sleep(5000);
            return new ElectricityConsumptionPage(Driver);
        }
    }
}
