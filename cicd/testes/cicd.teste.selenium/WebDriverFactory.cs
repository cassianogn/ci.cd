using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicd.teste.selenium
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver()
        {
            IWebDriver webDriver;

            webDriver = new ChromeDriver();

            return webDriver;
        }
    }
}
