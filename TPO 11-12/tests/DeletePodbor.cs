using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Driver;
using Tests.model;
using Tests.pages;
using Tests.service;

namespace Tests.tests
{
    public class DeletePodbor
    {
        [Test]
        public void DeletePodborTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();
            User user = UserCreator.user;

            MainPages mainPages = new MainPages();
            PodborPages podborPages = new PodborPages();
            PageFactory.InitElements(properties.driver, mainPages);
            mainPages.Login(user);

            mainPages.Avatar.Click();
            mainPages.Podbor.Click();
            Thread.Sleep(2000);

            PageFactory.InitElements(properties.driver, podborPages);
            podborPages.Redat.Click();
            podborPages.Delete.Click();
            podborPages.DeleteYes.Click();

            properties.logging.logstr = "Test DeleteBookBiblioTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
