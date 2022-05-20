using NUnit.Framework;
using seffaflik.epias.BaseClass;
using seffaflik.epias.Pages;
using Seffaflik.Epias.Test.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace seffaflik.epias.TestScripts
{
   
    public class TC1_CalculateDifference : BaseTest
    {
        [Test]
        public void Calculate()
        {
            var homePage = new HomePage(driver);
            var electricityGenarationPage =  homePage.LocatetoElectricityGenarationPage();
            electricityGenarationPage.enterDate("30.04.2021", "30.04.2021");
            electricityGenarationPage.AmountofGeneration();


            var electricityConsumptionPage = homePage.LocatetoElectricityConsumptionPage();
            electricityConsumptionPage.enterDate("30.04.2021", "30.04.2021");

            for (int i = 0; i < electricityGenarationPage.myList.Count; i++)
            {
                Console.WriteLine("saat " + electricityConsumptionPage.getTimes(i) + " 'de Gerçek Zamanlı Üretim ve Gerçek Zamanlı Tüketim farkı  = " 
                    + (electricityGenarationPage.GetGeneration(i) - electricityConsumptionPage.GetConsumption(i)));
            }            
        }

        [TearDown]
        public void CloseWindow()
        {
            driver.Quit();
        }
    }
}
