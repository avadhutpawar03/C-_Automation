﻿
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace MediBuddy
{
    public class Buddy
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);



            driver.Url = "https://www.medibuddy.in/";
            driver.Manage().Window.Maximize();



            driver.FindElement(By.XPath("//a[contains(text(),'Login')]")).Click();
            driver.FindElement(By.XPath("//div[@class='coperate']")).Click();
            driver.FindElement(By.XPath("//div[text()='Login using Username & Password']")).Click();
            driver.FindElement(By.Name("userName")).SendKeys("John");
            driver.FindElement(By.XPath("//button[text()='Proceed']")).Click();
            driver.FindElement(By.Name("password")).SendKeys("John123");
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//button[text()='Log in']")).Click();
            // Thread.Sleep(1000);



        }
    }
}