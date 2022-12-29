using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.pages
{
    public class BlogPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"search-results\"]/div/p/a")]
        public IWebElement ButtonNew { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"Title\"]")]
        public IWebElement InputZag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"createPost\"]/div[3]/div[2]/div[3]/div")]
        public IWebElement InputText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"createPost\"]/div[5]/div/select")]
        public IWebElement Vision { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"createPost\"]/div[8]/button[1]")]
        public IWebElement PublicBlog { get; set; }

    }
}
