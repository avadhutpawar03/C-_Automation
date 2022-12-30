using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Maveric.SeleniumAdvance
{
    public class MultipletabsTest
    {
        [Test]
        public void Demo1PhpMyAdminTabTest()
        {
            // Console.WriteLine("Hello");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.XPath("//b[text()='phpMyAdmin »']")).Click();
        }
        [Test]
        public void Demo2PhpMyAdminTabTest()
        {
            // Console.WriteLine("Hello");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.XPath("//b[text()='phpMyAdmin »']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("John");



            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            driver.FindElement(By.Id("input_go")).Click();
            // driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);
            driver.Quit();


        }


    }
}


