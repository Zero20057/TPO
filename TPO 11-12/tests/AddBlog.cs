using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    public class AddBlog
    {
        [Test]
        public void AddBlogTest()
        {
            CommonConditional properties = new CommonConditional();
            properties.Setup();
            User user = UserCreator.user;

            MainPages mainPages = new MainPages();
            BlogPages blogPages = new BlogPages();
            PageFactory.InitElements(properties.driver, mainPages);
            mainPages.Login(user);

            mainPages.Avatar.Click();
            mainPages.Blog.Click();
            Thread.Sleep(2000);

            PageFactory.InitElements(properties.driver, blogPages);
            blogPages.ButtonNew.Click();
            blogPages.InputZag.SendKeys("First");
            blogPages.InputText.SendKeys("First public");
            var selectElement = blogPages.Vision;
            var select = new SelectElement(selectElement);
            select.SelectByValue("3");
            blogPages.PublicBlog.Click();

            properties.logging.logstr = "Test DeleteBookBiblioTest Success";
            properties.logging.LogText();
            DriverSingleton.CloseDriver();
        }
    }
}
