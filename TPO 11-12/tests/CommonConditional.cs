using OpenQA.Selenium;
using Tests.Driver;
using Tests.util;

namespace Tests.tests
{
    public class CommonConditional
    {
        public log logging = new log();
        public WebDriver driver = DriverSingleton.getDriver();
        string test_url = "https://author.today/";
        [SetUp]
        public void Setup()
        {
            logging.logstr = "Beggining Tests";
            logging.LogText();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(test_url);
            Thread.Sleep(2000);
        }
    }
}
