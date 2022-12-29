using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class SalesForce
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Name("UserFirstName")).SendKeys("john");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            dropdown.SelectByIndex(5);
            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");


            SelectElement dropdown1 = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));

            dropdown1.SelectByIndex(3);

            driver.FindElement(By.Name("UserPhone")).SendKeys("9876543210");

            SelectElement dropdown3 = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            dropdown3.SelectByText("United Kingdom");


            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click(); 

  














        }
    }
}
