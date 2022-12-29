using SeleniumExtras.PageObjects;
using Tests.Driver;
using Tests.model;
using Tests.pages;
using Tests.service;

namespace Tests.tests
{
    internal class AddBookBiblio
    {
        [Test]
        public void AddBookBiblioTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();
            User user = UserCreator.user;

            MainPages mainPages = new MainPages();
            BookPages bookPages = new BookPages();
            SearchPages searchPages = new SearchPages();
            PageFactory.InitElements(properties.driver, mainPages);
            mainPages.Login(user);

            mainPages.SearchArea.Click();
            mainPages.SearchInput.SendKeys("Божья коровка");
            mainPages.SearchButtonEnter.Click();

            PageFactory.InitElements(properties.driver, searchPages);
            searchPages.BookName.Click();

            PageFactory.InitElements(properties.driver, bookPages);
            bookPages.BookBiblioIn.Click();
            bookPages.BookBiblioInAdd.Click();

            properties.logging.logstr = "Test AddBookBiblioTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
