using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParaBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";

            driver.FindElement(By.Name("firstName")).SendKeys("Rohan");
            driver.FindElement(By.Name("lastName")).SendKeys("patil");
            driver.FindElement(By.Name("phone")).SendKeys("3212321");
            driver.FindElement(By.Name("userName")).SendKeys("Rohan@gmail.com");
            driver.FindElement(By.Name("address1")).SendKeys("Swargate");
            driver.FindElement(By.Name("city")).SendKeys("Pune");
            driver.FindElement(By.Name("state")).SendKeys("Mahashtra");
            driver.FindElement(By.Name("postalCode")).SendKeys("411042");

            driver.FindElement(By.Name("submit")).Click();


        }
    }
}
