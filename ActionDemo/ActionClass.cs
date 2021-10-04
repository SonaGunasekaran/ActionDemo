using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionDemo
{
    public class ActionClass:Base.Baseclass
    {
       public static void CheckDargAndDrop()
       {
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='credit2']/a"));

            IWebElement element2 = driver.FindElement(By.XPath("//*[@id='bank']/li"));
            System.Threading.Thread.Sleep(1000);

            Actions action = new Actions(driver);
            action.DragAndDrop(element1, element2).Build().Perform();
            System.Threading.Thread.Sleep(1000);

            IWebElement dropElement = driver.FindElement(By.XPath("//*[@id='bank']/li"));
            String textTo = dropElement.Text;
            Console.WriteLine(textTo);

            if (textTo.Equals("BANK"))
            {
                Console.WriteLine("PASS : File is dropped to target as expected");
            }
            else
            {
                Console.WriteLine("FAIL : File couldn't be dropped to target as expected");
            }
            System.Threading.Thread.Sleep(1000);

            action.MoveToElement(element1);
            System.Threading.Thread.Sleep(1500);

        }
    }
}
