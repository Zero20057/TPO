using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tests.pages
{
    class BiblioPages
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Божья коровка']")]
        public IWebElement Book { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Анатолий Дроздов']")]
        public IWebElement User { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root-reply-placeholder\"]/comment-form-v1/form/div/div/div/div")]
        public IWebElement Comment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root-reply-placeholder\"]/comment-form-v1/form/div/div/div[3]/div")]
        public IWebElement CommentText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root-reply-placeholder\"]/comment-form-v1/form/button")]
        public IWebElement CommentPublic { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[2]/div/div[2]/div[2]/div[2]/div[2]/div/div[1]/div[2]/footer/a[3]")]
        public IWebElement CommentRedat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[2]/div/div[2]/div[2]/div[2]/div[2]/div/div[1]/div[2]/article/comment-form-v1/form/button[3]")]
        public IWebElement CommentDelete { get; set; }
    }
}
