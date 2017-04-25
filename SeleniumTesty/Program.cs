using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTesty
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://mail.google.com");

            driver.FindElement(By.XPath(".//*[@id='Email']")).SendKeys("DDDLProjekt");
            driver.FindElement(By.XPath(".//*[@id='next']")).Click();

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='Passwd']")).SendKeys("Projekt123");
            driver.FindElement(By.XPath(".//*[@id='signIn']")).Click();
            System.Threading.Thread.Sleep(2000);
         
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath(".//*[text()= 'UTWÓRZ']")).Click();

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//textarea[contains(@aria-label, 'Do')]")).Click();
            driver.FindElement(By.XPath(".//textarea[contains(@aria-label, 'Do')]")).SendKeys("dddlprojekt@gmail.com");

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@name='subjectbox']")).SendKeys("To jest Test Selenium");
   
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[contains(@aria-label,'Treść wiadomości')][1]")).SendKeys("teraz każdemu zadziała ;D xD \n XPath by D.");
           
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("(.//*[@aria-label='Wyślij ‪(Ctrl+Enter)‬'])")).Click();

           
            
 
        }
    }
}
