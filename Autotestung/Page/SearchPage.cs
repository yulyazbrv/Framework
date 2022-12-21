using OpenQA.Selenium;

namespace Autotestung.Page
{
    internal class SearchPage
    {
        private IWebDriver driver;
        private readonly By _SearchButton = By.XPath("//*[@id=\"ac-gn-searchform-submit\"]");

        private readonly By _SearchInput = By.XPath("//*[@id=\"ac-gn-link-search\"]");
        private readonly By _SearchField = By.XPath("//*[@id=\"ac-gn-searchform-input\"]");
        private readonly By _buy = By.XPath("//*[@id=\"exploreCurated\"]/div[1]/div[2]/ul/li[2]/a");

        private readonly By _comparer = By.XPath("//*[@id=\"exploreCurated\"]/div[1]/div[2]/ul/li[3]/a");
        //*[@id="tab-8b17e840-8150-11ed-a9d8-bdcaaaf518fb-1"]
        //*[@id="8b17e840-8150-11ed-a9d8-bdcaaaf518fb"]/div[1]/div/div/ul/li[2]

        private readonly By _color = By.XPath("//*[@id=\"title-4e947de0-814e-11ed-b8df-33949d3b13d2-10\"]");


        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }
      
        private void ClickForSearch()
        {
            driver.FindElement(_SearchInput).Click();
        }
        private void ClickSearchButton()
        {
            driver.FindElement(_SearchButton).Click();
        }
        private void InputSearch(string search)
        {
            driver.FindElement(_SearchField).SendKeys(search);
        }
        public void ComparerButton()
        {
            var s = driver.FindElement(_comparer);
            s.Click();

        }
        public void SetColor()
        {
            driver.FindElement(_color).Click();
        }
        public void BuyButton()
        {
            driver.FindElement(_buy).Click();
        }
        public void Search(Model.Search search )
        {
            ClickForSearch();
            InputSearch(search.SearchTest);
            ClickSearchButton();
        }

        public void SearchSE(Model.Search search)
        {
            ClickForSearch();
            InputSearch(search.SearchTest);
            ClickSearchButton();
            BuyButton();
        }
        
    }
}