using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationFramework;
using AutomationFramework.PageObjects;
using OpenQA.Selenium;
using System.Threading;
using System.Linq;

namespace SandboxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var page = new HomePage();
            page.Open();
            if (page.IsOpened)
            {
                var status = page.SignIn("0974885535", "aston133");
                Assert.IsTrue(status, "Login was successful");
            }
            else
            {
                Assert.Fail("Page was not opened");
            }
        }


        [TestCleanup]
        public void Cleanup()
        {
            Browser.Instance.Quit();
            Browser.Instance.Dispose();
        }
    }
}
