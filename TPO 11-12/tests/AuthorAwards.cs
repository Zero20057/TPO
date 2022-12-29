using SeleniumExtras.PageObjects;
using Tests.Driver;
using Tests.model;
using Tests.pages;
using Tests.service;

namespace Tests.tests
{
    public class AuthorAwards
    {
        [Test]
        public void AuthorAwardsTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();
            User user = UserCreator.user;

            MainPages mainPages = new MainPages();
            BiblioPages biblioPages = new BiblioPages();
            AuthorPages authorPages = new AuthorPages();
            PageFactory.InitElements(properties.driver, mainPages);
            mainPages.Login(user);

            mainPages.Biblio.Click();
            PageFactory.InitElements(properties.driver, biblioPages);
            biblioPages.User.Click();
            Thread.Sleep(2000);
            PageFactory.InitElements(properties.driver, authorPages);
            authorPages.Other.Click();
            authorPages.Awards.Click();

            properties.logging.logstr = "Test AuthorAwardsTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
