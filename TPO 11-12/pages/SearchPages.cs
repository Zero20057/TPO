using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tests.pages
{
    internal class SearchPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"search-results\"]/div[2]/div[2]/div[2]/div[1]/div[2]/h4/a/em[1]")]
        public IWebElement BookName { get; set; }
    }
}
