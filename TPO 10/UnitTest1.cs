using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using SeleniumExtras.PageObjects;
using Tests.pages;

namespace Tests
{
    public class Tests
    {
        String test_url = "https://author.today/";

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:/Program Files/Google/Chrome/Application");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void DeleteBookBiblio()
        {
            driver.Navigate().GoToUrl(test_url);
            System.Threading.Thread.Sleep(2000);

            MainPages mainPages = new MainPages();
            BiblioPages biblioPages = new BiblioPages();
            BookPages bookPages = new BookPages();
            PageFactory.InitElements(driver, mainPages);
            mainPages.LoginWin.Click();
            System.Threading.Thread.Sleep(2000);
            mainPages.LoginText.SendKeys("nataliarybcinskaa73@gmail.com");
            mainPages.PasswordText.SendKeys("tfvbhy596");
            mainPages.LoginButon.Click();
            System.Threading.Thread.Sleep(2000);

            mainPages.Biblio.Click();
            PageFactory.InitElements(driver, biblioPages);
            biblioPages.Book.Click();
            PageFactory.InitElements(driver, bookPages);
            bookPages.BookBiblioIn.Click();
            bookPages.BookBiblioInDel.Click();
        }

        [Test]
        public void BookSearchJanr()
        {
            driver.Navigate().GoToUrl(test_url);
            System.Threading.Thread.Sleep(2000);

            MainPages mainPages = new MainPages();
            PageFactory.InitElements(driver, mainPages);
 
            mainPages.BookSearch.Click();
            mainPages.BookSearchFantesy.Click();
        }

        [Test]
        public void AddBookBiblio()
        {
            driver.Navigate().GoToUrl(test_url);
            System.Threading.Thread.Sleep(2000);

            MainPages mainPages = new MainPages();
            BookPages bookPages = new BookPages();
            SearchPages searchPages = new SearchPages();
            PageFactory.InitElements(driver, mainPages);
            mainPages.LoginWin.Click();
            System.Threading.Thread.Sleep(2000);
            mainPages.LoginText.SendKeys("nataliarybcinskaa73@gmail.com");
            mainPages.PasswordText.SendKeys("tfvbhy596");
            mainPages.LoginButon.Click();
            System.Threading.Thread.Sleep(2000);

            mainPages.SearchArea.Click();
            mainPages.SearchInput.SendKeys("Божья коровка");
            mainPages.SearchButtonEnter.Click();

            PageFactory.InitElements(driver, searchPages);
            searchPages.BookName.Click();

            PageFactory.InitElements(driver, bookPages);
            bookPages.BookBiblioIn.Click();
            bookPages.BookBiblioInAdd.Click();
        }


    }
}