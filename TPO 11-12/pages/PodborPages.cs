using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.pages
{
    public class PodborPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[2]/div[1]/p/a")]
        public IWebElement ButtonNew { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"Title\"]")]
        public IWebElement InputZag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"Description\"]")]
        public IWebElement InputText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"editCollection\"]/div[6]/button")]
        public IWebElement PublicBlog { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[2]/div/div/footer/a")]
        public IWebElement Redat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"pjax-container\"]/section/div/div[3]/div[2]/button")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/modal-dialog/div/div/div/div[2]/div[2]/button[2]")]
        public IWebElement DeleteYes { get; set; }
    }
}
