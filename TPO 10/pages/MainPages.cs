using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

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
    }
}
