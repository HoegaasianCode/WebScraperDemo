using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebScraperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://www.google.com");
            var element = webDriver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            element.SendKeys("WebShop");
            element.Submit();
            var titles = webDriver.FindElements(By.Id("rso"));
            foreach(var title in titles)
            {
                Console.WriteLine(title.Text);
            }
        }
    }
}
