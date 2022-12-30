using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo
{
    public class Go1
   
    {
        public class Goto
        {
            //public static void Main(string[] args)
            {



                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Url = "https://www.goto.com/meeting/";
                // Console.WriteLine(driver.PageSource);

                driver.FindElement(By.Id("truste-consent-button")).Click();



                Actions act = new Actions(driver);
                try
                {
                    act.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
                }
                catch
                {

                }
                //act.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();

                driver.FindElement(By.LinkText("Try Free")).Click();



                driver.FindElement(By.Id("first-name")).SendKeys("ABC");
                driver.FindElement(By.XPath("last-name")).SendKeys("XYZ");
                driver.FindElement(By.XPath("login__email")).SendKeys("abc@gmail.com");
                //driver.FindElement(By.XPath("//label[text()='Phone Number (Optional)']")).SendKeys("8234724128");
                SelectElement dropdown = new SelectElement(driver.FindElement(By.XPath("//select[@class='select__select  ']")));
                dropdown.SelectByText("10 - 99");





            }
        }
    }


}
   
