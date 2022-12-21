using Autotestung.Driver;
using Autotestung.Services;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;

namespace Autotestung
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            
            driver =  DrivarSingilton.GetWebDriver();
            driver.Navigate().GoToUrl("https://www.apple.com/");
            

        }
        [Test]////
        public void TestRepair()
        {
            Page.Repair loginPage = new Page.Repair(driver);
            loginPage.RepairButton();
        }
        [Test]////
        public void LearnMore()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            loginPage.LearnMoreButton();
        }
        [Test]////
        public void Support()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            loginPage.SupportButton();
        }
        [Test]////
        public void NearButton()
        {
            Page.LocatorPage searchPage = new Page.LocatorPage(driver);
            searchPage.SearchCity(SearchServices.WithSearchFromPropertySE());
        }

        [Test]////
        public void SearchForEmpty()
        {
            Page.SearchPage searchPage = new Page.SearchPage(driver);
            searchPage.Search(SearchServices.WithEmptySearch());
            //Assert.AreEqual(SearchErrorsEmptyResult, searchPage.MessageErors);
        }
        [Test]////
        public void BuySE()
        {
            Page.SearchPage searchPage = new Page.SearchPage(driver);
            searchPage.SearchSE(SearchServices.WithSearchFromPropertySE());
            //Assert.AreEqual(SearchErrorsEmptyResult, searchPage.MessageErors);
        }
        [Test]////
        public void SearchForIphone()
        {
            Page.SearchPage searchPage = new Page.SearchPage(driver);
            searchPage.Search(SearchServices.WithSearchFromProperty());
            //Assert.AreEqual(SearchServices.WithSearchFromProperty().SearchTest, searchPage.MessageErors);
        }
        /*[Test]////
        public void TestBag()
        {
            Page.Remove loginPage = new Page.Remove(driver);
            loginPage.TryToSeeBag();
            loginPage.ClickBag();
        }*/
        [Test]////
        public void TryToCompare()
        {
            Page.SearchPage searchPage = new Page.SearchPage(driver);
            searchPage.Search(SearchServices.WithSearchFromProperty());
            searchPage.ComparerButton();
            //Assert.AreEqual(SearchServices.WithSearchFromProperty().SearchTest, searchPage.MessageErors);
        }
    }
}