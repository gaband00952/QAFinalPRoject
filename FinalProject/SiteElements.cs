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

        ////Navigate to the signup page
        public static IWebElement CreateNewUser(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Click Here"));

        }

        //Enter first name  on the sign up  page
        public static IWebElement txtEnterFirstName(IWebDriver driver)
        {
            return driver.FindElement(By.Id("firstname"));

        }

        //enter last name on the sign up page
        public static IWebElement txtEnterLastName(IWebDriver driver)
        {
            return driver.FindElement(By.Id("lastname"));

        }

        //enter email on the sign up page
        public static IWebElement txtEnterEmail(IWebDriver driver)
        {
            return driver.FindElement(By.Id("email"));

        }

        //enter screen name on the sign up page
        public static IWebElement txtEnterScreenName(IWebDriver driver)
        {
            return driver.FindElement(By.Id("username"));

        }

        //enter password on the sign up page
        public static IWebElement txtEnterNewPassword(IWebDriver driver)
        {
            return driver.FindElement(By.Id("password"));

        }

        //enter confirm password on the sign up page
        public static IWebElement txtConfirmPassword(IWebDriver driver)
        {
            return driver.FindElement(By.Id("confirm"));

        }

        //enter phone number on the sign up page
        public static IWebElement txtPhoneNumber(IWebDriver driver)
        {
            return driver.FindElement(By.Id("phone"));

        }

        //enter address on the sign up page
        public static IWebElement txtAddress(IWebDriver driver)
        {
            return driver.FindElement(By.Id("address"));

        }

        //enter province on the sign up page
        public static IWebElement lstProvince(IWebDriver driver)
        {
            return driver.FindElement(By.Id("province"));

        }

        //enter postal code on the sign up page
        public static IWebElement txtPostalCode (IWebDriver driver)
        {
            return driver.FindElement(By.Id("postalCode"));

        }

        //enter URL on the sign up page
        public static IWebElement txtURL(IWebDriver driver)
        {
            return driver.FindElement(By.Id("url"));

        }

        //enter description on the sign up page
        public static IWebElement txtDescription(IWebDriver driver)
        {
            return driver.FindElement(By.Id("desc"));

        }

        //enter location on the sign up page
        public static IWebElement txtLocation(IWebDriver driver)
        {
            return driver.FindElement(By.Id("location"));

        }

        //Register button on the sign up page
        public static IWebElement btnRegister(IWebDriver driver)
        {
            return driver.FindElement(By.Id("button"));

        }

    }
}
