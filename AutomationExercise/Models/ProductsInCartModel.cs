using AutomationExercise.WebDriver;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace AutomationExercise.Models
{
    public class ProductsInCartModel
    {
        public void ClickProducts()
        {
            Driver.Click(By.XPath("//a[text()=' Products']"));
        }
        
        public void ProductAdd()
        {
            Driver.ScrollBy(0, 500);
            ReadOnlyCollection<IWebElement> elements = Driver.FindElements("//div[@class='productinfo text-center']/a");
            elements[0].Click();
        }

        public void ClickContinue(string text)
        {
            Driver.Click(By.XPath("//button[text()='" + text + "']"));
        }
        
        public void HoverProductAdd()
        {           
            ReadOnlyCollection<IWebElement> elements = Driver.FindElements("//div[@class='productinfo text-center']/a");
            Driver.MoveToElements(elements[1]);
            Driver.ScrollBy(0, 500);
            elements[1].Click();
        }

        public void ClickViewCart()
        {
            Driver.Click(By.XPath("//u[text()='View Cart']"));
        }
        
        public void AdvertisementClose()
        {
            Driver.Click(By.XPath("//u[text()='View Cart']"));
        }
        
        public int VerifyProducts()
        {
            ReadOnlyCollection<IWebElement> elements = Driver.FindElements("//tbody/tr");
            return elements.Count;
        }
        
        public int VerifyProductPrice()
        {
            ReadOnlyCollection<IWebElement> elements = Driver.FindElements("//td[@class='cart_price']/p");
            return elements.Count;
        }
        
        public int VerifyProductQuantity()
        {
            ReadOnlyCollection<IWebElement> elements = Driver.FindElements("//td[@class='cart_quantity']");
            return elements.Count;
        }
        
        public int VerifyProductTotal()
        {
            ReadOnlyCollection<IWebElement> elements = Driver.FindElements("//p[@class='cart_total_price']");
            return elements.Count;
        }

    }
}
