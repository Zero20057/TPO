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
    public class AddComment
    {
        [Test]
        public void AddCommentTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();
            User user = UserCreator.user;

            MainPages mainPages = new MainPages();
            BiblioPages biblioPages= new BiblioPages();
            PageFactory.InitElements(properties.driver, mainPages);
            mainPages.Login(user);

            mainPages.Avatar.Click();
            mainPages.Profile.Click();
            Thread.Sleep(2000);

            PageFactory.InitElements(properties.driver, biblioPages);
            biblioPages.Comment.Click();
            biblioPages.CommentText.SendKeys("Тест");
            Thread.Sleep(1000);
            biblioPages.CommentPublic.Click();

            properties.logging.logstr = "Test DeleteBookBiblioTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
