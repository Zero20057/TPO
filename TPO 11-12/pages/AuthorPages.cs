using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tests.pages
{
    public class AuthorPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[1]/div[1]/div[3]/button[1]/span")]
        public IWebElement AuthorSubcribe { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[text()='Моя библиотека']")]
        public IWebElement Biblio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[1]/div[2]/nav/ul/li[6]/a")]
        public IWebElement Other { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[1]/div[2]/nav/ul/li[6]/ul/li[2]/a")]
        public IWebElement Awards { get; set; }
    }
}
