using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            driver.Url = "http://10.157.123.12/site8/Login.php";

        }
            
            public static void SiteReset()
            {

            string myConnectionString = "server=10.157.123.12;database=bitter-site8;uid=site8;pwd=gP0Sdwf0Ga4Tij20;";
           

            }
    }
}
