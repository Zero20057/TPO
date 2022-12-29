using SeleniumExtras.PageObjects;
using Tests.Driver;
using Tests.pages;

namespace Tests.tests
{
    public class BookSearchJanr
    {
        [Test]
        public void BookSearchJanrTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();

            MainPages mainPages = new MainPages();
            PageFactory.InitElements(properties.driver, mainPages);

            mainPages.BookSearch.Click();
            mainPages.BookSearchFantesy.Click();

            properties.logging.logstr = "Test BookSearchJanrTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
