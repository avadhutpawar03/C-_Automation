using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo
{
    public class Go1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.goto.com/meeting";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//button[text()='Accept Recommended Settings']")).Click();



        }
    }
}
