using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Tests.model;

namespace Tests.pages
{
    class MainPages
    {

        [FindsBy(How = How.XPath, Using = "//a[text()='Войти']")]
        public IWebElement LoginWin { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Login']")]
        public IWebElement LoginText { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='Password']")]
        public IWebElement PasswordText { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Войти']")]
        public IWebElement LoginButon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Моя библиотека']")]
        public IWebElement Biblio { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navbar\"]/ul/li[1]/a")]
        public IWebElement BookSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Фэнтези']")]
        public IWebElement BookSearchFantesy { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navbar-right\"]/li[2]/a")]
        public IWebElement SearchArea { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/nav/form/div/input")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/nav/form/span/button")]
        public IWebElement SearchButtonEnter { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navbar-right\"]/li[6]/ul/li[2]/a")]
        public IWebElement Blog { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navbar-right\"]/li[6]/a/div")]
        public IWebElement Avatar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navbar-right\"]/li[6]/ul/li[5]/a")]
        public IWebElement Podbor { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"navbar-right\"]/li[6]/ul/li[7]/a")]
        public IWebElement Profile { get; set; }

        public void Login(User user)
        {
            LoginWin.Click();
            Thread.Sleep(2000);
            LoginText.SendKeys(user.getUsername());
            PasswordText.SendKeys(user.getPassword());
            LoginButon.Click();
            Thread.Sleep(2000);
        }
    }
}
