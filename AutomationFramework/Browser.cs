using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public static class Browser
    {
        static Browser()
        {
            Instance = new ChromeDriver(@"C:\Users\Larchi\Documents\visual studio 2017\Projects\AutomationFramework\AutomationFramework\bin\Debug");
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Instance.Manage().Window.Maximize();
        }
        public static IWebDriver Instance { get; }

        public static void GoToURL(string url)
        {
            Instance.Navigate().GoToUrl(url);
        }
    }
}
