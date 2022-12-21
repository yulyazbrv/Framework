using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Page
{
    internal class Repair
    {
        private IWebDriver driver;
        private readonly By _support = By.XPath("//*[@id=\"ac-globalnav\"]/div/ul[2]/li[11]/a");
        private readonly By _repair = By.XPath("/html/body/div[6]/div[3]/div/a[2]/div/span[1]");


        public Repair(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void RepairButton()
        {
            driver.FindElement(_support).Click();
            driver.FindElement(_repair).Click();
        }
    }
}
