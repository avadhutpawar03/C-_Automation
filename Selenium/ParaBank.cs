using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParaBank
{
    public class ParaBank
    {
        static void Main(string[] args)
            {
             
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";

            driver.FindElement(By.Id("customer.firstName")).SendKeys("jack");
            driver.FindElement(By.Name("customer.lastName")).SendKeys("kim");
            driver.FindElement(By.Name("customer.address.street")).SendKeys("Swargate");
            driver.FindElement(By.Name("customer.address.city")).SendKeys("PUNE");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("212121212");
            driver.FindElement(By.Name("customer.address.zipCode")).SendKeys("411042");
            driver.FindElement(By.Name("customer.address.state")).SendKeys("Maharashtra");
            driver.FindElement(By.Name("customer.ssn")).SendKeys("1234");
            driver.FindElement(By.Id("customer.username")).SendKeys("Jack@223.com");
            driver.FindElement(By.Id("customer.password")).SendKeys("12332");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("12332");

            driver.FindElement(By.CssSelector("input[value='Register']")).Click();



        }




    }
    
    }


