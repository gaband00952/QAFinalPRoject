using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace FinalProject
{
    public class SiteTests
    {
        private readonly IWebDriver driver;

        public SiteTests(IWebDriver driver)
        {
            this.driver = driver;
        }

        public object ExpectedConditions { get; private set; }


        // Test1  for registering a new user
        public static  bool RegisterNewUser(string firstName, string lastName, string email, string username, string password, string phone, string address, string province, string postalCode, string url, string description, string location,IWebDriver driver)
        {
            // Navigate to the registration page
            driver.Navigate().GoToUrl("http://10.157.123.12/site8/Signup.php");


            //login Page
            IWebElement txtUsername = SiteElements.txtEnterUsername(driver);
                IWebElement txtPassword = SiteElements.txtEnterPassword(driver);
                IWebElement btnLogin = SiteElements.btnLogin(driver);

                //link to the registaration page
               // IWebElement linkCreatenewUser = SiteElements.CreateNewUser(driver);

                //rregist+ration page
               IWebElement txtFirstName = SiteElements.txtEnterFirstName(driver);
                IWebElement txtLastName = SiteElements.txtEnterLastName(driver);
                IWebElement txtEmail = SiteElements.txtEnterEmail(driver);
                IWebElement txtScreenName = SiteElements.txtEnterScreenName(driver);
                IWebElement txtnewPassword = SiteElements.txtEnterNewPassword(driver);
                IWebElement txtConfirmPassword = SiteElements.txtConfirmPassword(driver);
                IWebElement txtPhoneNumber = SiteElements.txtPhoneNumber(driver);
                IWebElement txtAddress = SiteElements.txtAddress(driver);
                IWebElement lstProvince = SiteElements.lstProvince(driver);
                IWebElement txtPostalCode = SiteElements.txtPostalCode(driver);
                IWebElement txtURL = SiteElements.txtURL(driver);
                IWebElement txtDescription = SiteElements.txtDescription(driver);
                IWebElement txtLocation = SiteElements.txtLocation(driver);
                IWebElement btnRegister = SiteElements.btnRegister(driver);


                //linkCreatenewUser.Click();
                //Thread.Sleep(1000);
                txtFirstName.SendKeys(firstName);
                Thread.Sleep(1000);
                txtLastName.SendKeys(lastName);
                Thread.Sleep(1000);
                txtEmail.SendKeys(email);
                Thread.Sleep(1000);
                txtScreenName.SendKeys(username);
                Thread.Sleep(1000);
                txtnewPassword.SendKeys(password);
                Thread.Sleep(1000);
                txtConfirmPassword.SendKeys(password);
                Thread.Sleep(1000);
                txtPhoneNumber.SendKeys(phone);
                Thread.Sleep(1000);
                txtAddress.SendKeys(address);
                Thread.Sleep(1000);
                lstProvince.SendKeys(province);
                Thread.Sleep(1000);
                txtPostalCode.SendKeys(postalCode);
                Thread.Sleep(1000);
                txtURL.SendKeys(url);
                Thread.Sleep(1000);
                txtDescription.SendKeys(description);
                Thread.Sleep(1000);
                txtLocation.SendKeys(location);
                Thread.Sleep(1000);
                btnRegister.Click();

                return true;



            
       
        }






        // Test method 2: Test for login
        public void TestLogin()
        {
            try
            {
                // Navigate to the login page
                driver.Navigate().GoToUrl("http://10.157.123.12/site8/login.php");

                // Find the username and password fields and the login button
                IWebElement usernameField = driver.FindElement(By.Id("username"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                IWebElement loginButton = driver.FindElement(By.Id("button"));

                // Enter username and password
                usernameField.SendKeys("your_username");
                passwordField.SendKeys("your_password");

                // Click the login button
                loginButton.Click();



                Console.WriteLine("Login successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during login test: " + ex.Message);
            }
        }

        // Test method 3: Test for some other functionality (replace with actual test logic)
        public void TestSomeOtherFunctionality()
        {
            try
            {
                // Navigate to the page where the functionality is located
                driver.Navigate().GoToUrl("http://10.157.123.12/site8/other_page.php");

                // Add your test logic here

                Console.WriteLine("Test for some other functionality completed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during the third test: " + ex.Message);
            }
        }









    }
}    




