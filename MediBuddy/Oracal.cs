using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediBuddy
{
   
        public class Ora
        {
            static void Main(string[] args)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                driver.Url = "https://www.oracle.com/in/database/";
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("acctBtnLabel")).Click();
                driver.FindElement(By.XPath("//a[@data-lbl='profile:sign-in-account']")).Click();
                String title = driver.Title;
                Console.WriteLine(title);
                String ur = driver.Url;
                Console.WriteLine(ur);
                Thread.Sleep(1000);
                IWebElement element = driver.FindElement(By.XPath(" //h2[contains(text(),'Oracle account sign in')]"));
                string text = element.Text;
                Console.WriteLine(text);
                Thread.Sleep(1000);
                driver.FindElement(By.Name("ssousername")).SendKeys("John");
                driver.FindElement(By.Name("password")).SendKeys("John123");
                driver.FindElement(By.Id("signin_button")).Click();
                Thread.Sleep(1000);
                String actual_err = driver.FindElement(By.XPath("//span[@id=\"errormsg\"]")).Text;
                Console.WriteLine(actual_err);

            }
        }
    }

