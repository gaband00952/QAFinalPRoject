using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Security.Policy;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            //Navigate to the regestration page to make sure the link works
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");
            bool formTest1;

            formTest1 = SiteTests.RegisterNewUser("Sally","trailmix","coolEmail@gmail.com", "SalTra678", "password","506 123 4567","55 cool street","NB","D4X 8G2","Github.com","Description","Fredericton",driver);

            Console.WriteLine("Validform Result: " + formTest1);
            driver.Close();

            driver.Url = "http://10.157.123.12/site8/Login.php";


        }
        } 
    }
