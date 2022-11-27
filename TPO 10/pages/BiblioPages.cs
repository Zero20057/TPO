using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.pages
{
    class BiblioPages
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Божья коровка']")]
        public IWebElement Book { get; set; }
    }
}
