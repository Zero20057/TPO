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
    public class DeleteComment
    {
        [Test]
        public void DeleteCommentTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();
            User user = UserCreator.user;

            MainPages mainPages = new MainPages();
            BiblioPages biblioPages = new BiblioPages();
            PageFactory.InitElements(properties.driver, mainPages);
            mainPages.Login(user);

            mainPages.Avatar.Click();
            mainPages.Profile.Click();
            Thread.Sleep(2000);

            PageFactory.InitElements(properties.driver, biblioPages);
            biblioPages.CommentRedat.Click();
            biblioPages.CommentDelete.Click();

            properties.logging.logstr = "Test DeleteBookBiblioTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
