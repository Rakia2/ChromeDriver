using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DriverManagement
{

    public class Program
    {

    



        public static void Main() {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine("Testing...");




        }


    }






}