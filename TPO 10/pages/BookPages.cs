using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.pages
{
    class BookPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div[2]/div/div[1]/div[1]/div/div/div[1]/div[2]/library-button/div/button")]
        public IWebElement BookBiblioIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Удалить из библиотеки']")]
        public IWebElement BookBiblioInDel { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Читаю']")]
        public IWebElement BookBiblioInAdd { get; set; }
    }
}
