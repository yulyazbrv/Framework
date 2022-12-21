using Autotestung.Model;
using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Page
{
    internal class LoginPage
    {
        private readonly By _ClosBaner = By.XPath("//div[@class='banner_close close to___process']");
        private readonly By _ButtonAuth = By.XPath("//a[@class='btn-login-js']");

        private readonly By _singButton = By.XPath("//a[text()='Авторизация']");
        private readonly By _LoginInutButton = By.XPath("//input[@name='login']");
        private readonly By _PasswordInutButton = By.XPath("//input[@name='password']");
        private readonly By _ButtonEnter = By.XPath("//button[text()='Войти']");
        private readonly By _ErrorText = By.XPath("//p[@class='error___p']");

        private readonly By homePaheApple = By.XPath("/html/body/nav/div/ul[2]/li[5]/a");
        private readonly By learnMore = By.XPath("//*[@id=\"main\"]/section[2]/div[1]/div[1]/div/div[1]/ul/li[2]/a/span[1]");
        private readonly By phone = By.XPath("//*[@id=\"ac-globalnav\"]/div/ul[2]/li[2]/a");
        private readonly By support = By.XPath("//*[@id=\"generic-2\"]/div[1]/div/div[2]/div[2]/a");


        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory();
        private static readonly ILogger _logger = _loggerFactory.CreateLogger("CustomCategory");
        
        private IWebDriver driver;
        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void LearnMoreButton()
        {
            driver.FindElement(homePaheApple).Click();
            var s = driver.FindElement(learnMore);
            s.Click();
        }
        public void SupportButton()
        {
            driver.FindElement(phone).Click();
            var s = driver.FindElement(support);
            s.Click();
        }
        public void ClickByAuth()
        {
            {
                _logger.LogInformation("ClickByAuth");
                driver.FindElement(_ButtonAuth).Click();
                var singin = driver.FindElement(_singButton);
                singin.Click();
            }
        }
        public void inputLogin(string _login)
        {
            _logger.LogInformation("inputLogin");
            var login = driver.FindElement(_LoginInutButton);
            login.SendKeys(_login);
        }
        public void inputPasword(string _pasword)
        {
            _logger.LogInformation("inputPasword");
            var password = driver.FindElement(_PasswordInutButton);
            password.SendKeys(_pasword);
        }
        public void ClickEnter()
        {
            _logger.LogInformation("ClickEnter");
            var enter = driver.FindElement(_ButtonEnter);
            enter.Click();
        }
        public String MessageErors;
        public void Massege()
        {
            _logger.LogInformation("Massege");
            var massege = driver.FindElement(_ErrorText);
            MessageErors = massege.Text;
        }
        
        public String Login(User user)
        {
            _logger.LogInformation("Start Login Test -------");
            ClickByAuth();
            inputLogin(user.Login);
            inputPasword(user.Password);
            ClickEnter();
            Massege();
            _logger.LogInformation("Massege = " + MessageErors);
            return MessageErors;
        }
    }
}
