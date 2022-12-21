using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Page
{
    internal class Remove
    {
        private IWebDriver driver;
        private readonly By _menu = By.XPath("//*[@id=\"ac-gn-bag\"]/div/a");
        private readonly By _bag = By.XPath("//*[@id=\"ac-gn-bagview-content\"]/nav/ul/li[4]/a");


        public Remove(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TryToSeeBag()
        {
            driver.FindElement(_menu).Click();
            
        }
        public void ClickBag()
        {
            driver.FindElement(_bag).Click();
        }
    }
}
