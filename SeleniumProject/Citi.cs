using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class Citi
    {

            [Test]
            public void CitiBank()
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.Url = "https://www.online.citibank.co.in/";



                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);



                driver.FindElement(By.XPath("//a[@class='fancybox-item fancybox-close']")).Click();



                driver.FindElement(By.XPath("(//img[@title='LOGIN NOW'])[1]")).Click();
                Thread.Sleep(1000);





                driver.SwitchTo().Window(driver.WindowHandles[1]);



                Thread.Sleep(1000);



                driver.FindElement(By.XPath("//div[@onclick='ForgotUserID();']")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("(//a[text()='select your product type'])[1]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//a[text()='Credit Card']")).Click();
                //  select.SelectByText("Credit Card");



                driver.FindElement(By.Name("citiCard1")).SendKeys("4545");
                driver.FindElement(By.Name("citiCard2")).SendKeys("5656");
                driver.FindElement(By.Name("citiCard3")).SendKeys("1254");
                driver.FindElement(By.Name("citiCard4")).SendKeys("9996");



                //driver.FindElement(By.Name("CCVNO")).SendKeys("510");



                driver.FindElement(By.XPath("//input[@onkeypress='return numbersonly(event)']")).SendKeys("456");



                driver.FindElement(By.Name("DOB")).Click();



                driver.FindElement(By.XPath("(//select[@data-event='change'])[1]")).Click();



                // SelectElement s = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-month']")));
                //s.SelectByValue("Apr");



                driver.FindElement(By.XPath("//option[text()='Apr']")).Click();



                driver.FindElement(By.XPath("//a[text()='14']")).Click();



                //.driver.FindElement(By.Name("DOB")).SendKeys("4/04/2022");



                //driver.FindElement(By.Id("agree")).Click();



                driver.FindElement(By.XPath("//input[@value='PROCEED']")).Click();



                // string text = driver.FindElement(By.XPath("//p[contains(text(),'We are unable to process your request. Please try again later.')]")).Text;
                //Console.WriteLine(text);



                driver.SwitchTo().Window(driver.WindowHandles[2]);



                string s = driver.FindElement(By.XPath("(//li[contains(text(),'• Please accept Terms and Conditions ')])[3]")).Text;
                Console.WriteLine(s);
                //  driver.SwitchTo().Window(driver.WindowHandles[0]);
                // Console.WriteLine(driver.Title);
                // driver.Quit();



            }
        }
    }
