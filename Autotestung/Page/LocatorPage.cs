using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Page
{
    internal class LocatorPage
    {
        private IWebDriver driver;
        private readonly By _Store = By.XPath("//*[@id=\"ac-globalnav\"]/div/ul[2]/li[2]/a");
        private readonly By _Near = By.XPath("//*[@id=\"generic-2\"]/div[2]/div[2]/div[2]/a");
        private readonly By _phone = By.XPath("//*[@id=\"shelf-1_section\"]/div/div[1]/div/div/div[2]/div/div/div/div[2]/div/a");
        

        public LocatorPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private void StoreButton()
        {
            driver.FindElement(_Store).Click();
        }
        private void NearButton()
        {
            driver.FindElement(_Near).Click();
        }
       
        private void Phone()
        {
            driver.FindElement(_phone).Click();
        }
        public void SearchCity(Model.Search search)
        {
            StoreButton();
            Phone();
            NearButton();
        }
    }
}
