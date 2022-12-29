using SeleniumExtras.PageObjects;
using Tests.Driver;
using Tests.model;
using Tests.pages;
using Tests.service;

namespace Tests.tests
{
    public class DeleteBookBiblio
    {
        [Test]
        public void DeleteBookBiblioTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();
            User user = UserCreator.user;

            MainPages mainPages = new MainPages();
            BiblioPages biblioPages = new BiblioPages();
            BookPages bookPages = new BookPages();
            PageFactory.InitElements(properties.driver, mainPages);
            mainPages.Login(user);

            mainPages.Biblio.Click();
            PageFactory.InitElements(properties.driver, biblioPages);
            biblioPages.Book.Click();
            PageFactory.InitElements(properties.driver, bookPages);
            bookPages.BookBiblioIn.Click();
            bookPages.BookBiblioInDel.Click();

            properties.logging.logstr = "Test DeleteBookBiblioTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}