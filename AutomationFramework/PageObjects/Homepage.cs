using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    public class HomePage : Page
    {
        public HomePage() : base("https://rozetka.com.ua")
        {
        }

        public IWebElement LoginButton
        {
            get
            {
                return Browser.Instance.FindElement(By.Name("signin"));
            }
        }

        public IWebElement LoginField
        {
            get
            {
                return Browser.Instance.FindElement(By.Name("login"));
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                return Browser.Instance.FindElement(By.Name("password"));
            }
        }

        public IWebElement SubmitLoginButton
        {
            get
            {
                return Browser.Instance.FindElement(By.Name("auth_submit"));
            }
        }

        public IWebElement SocialSpam
        {
            get
            {
                return Browser.Instance.FindElements(By.CssSelector(".social-bind-tiny")).FirstOrDefault();
            }
        }


        public bool SignIn(string Login, string Password)
        {
            LoginButton.Click();
            Thread.Sleep(1000);
            LoginField.Clear();
            LoginField.SendKeys(Login);
            PasswordField.Clear();
            PasswordField.SendKeys(Password);
            SubmitLoginButton.Click();
            if (SocialSpam != null && SocialSpam.Displayed)
            {
                Browser.Instance.FindElement(By.Name("close")).Click();
            }
            if (Browser.Instance.FindElements(By.Id("header_user_menu")).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
