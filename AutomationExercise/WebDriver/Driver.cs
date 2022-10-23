using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;

namespace AutomationExercise.WebDriver
{
    public static class Driver
    {
        public static IWebDriver driver;
        private static IWebElement element;
        private static WebDriverWait wait;
        public static Actions action;
        private static SelectElement select;
        

        public static void DriverStart()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);            
        }
        public static void DriverQuit()
        {
            driver.Quit();
        }
        public static void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public static bool HomePageControl()
        {
            return driver.FindElement(By.XPath("//div[@class='logo pull-left']")).Displayed;
        }
        public static IWebElement FindElementXpath(string locator)
        {
            return driver.FindElement(By.XPath(locator));
        }
        public static IWebElement FindElementId(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public static IWebElement FindElementPartialLinkText(string locator)
        {
            return driver.FindElement(By.PartialLinkText(locator));
        }

        public static void ClickOkButton()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public static ReadOnlyCollection<IWebElement> FindElements(string xpath)
        {
            return driver.FindElements(By.XPath(xpath));
        }
        public static void SendKey(By key, string text)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(key)).SendKeys(text);
        }
        public static void MoveToElement(By key)
        {
            element = driver.FindElement(key);
            action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();            
        }
        public static void Click(By key)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementToBeClickable(key)).Click();
        }
        public static void SelectElementFromDropdown(By key, string value)
        {
            element = driver.FindElement(key);
            select = new SelectElement(element);
            select.SelectByText(value);
        }      
        
        public static string ElementIsVisible(By locator, int second)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return null;
            }
            catch (Exception e) 
            {
                return e.Message;
            }
        }
    }
}
