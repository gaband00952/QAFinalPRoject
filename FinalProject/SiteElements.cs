using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace FinalProject
{
    internal class SiteElements
    {
        //Enter username on the login page
        public static IWebElement txtEnterUsername(IWebDriver driver)
        {
            return driver.FindElement(By.Id("username"));

        }

        //Enter password on the login page
        public static IWebElement txtEnterPassword(IWebDriver driver)
        {
            return driver.FindElement(By.Id("password"));

        }

        //login button  on the login page
        public static IWebElement btnLogin(IWebDriver driver)
        {
            return driver.FindElement(By.Id("button"));

        }

    }
}
