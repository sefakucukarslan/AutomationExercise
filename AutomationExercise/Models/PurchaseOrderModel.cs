using AutomationExercise.WebDriver;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
namespace AutomationExercise.Models
{
    public class PurchaseOrderModel
    {
        public void AddProducts()
        {
            Driver.GoToUrl("https://www.automationexercise.com/products");
            Driver.ScrollBy(0, 500);
            ReadOnlyCollection<IWebElement> elements = Driver.FindElements("//div[@class='productinfo text-center']/a");
            elements[0].Click();
            Driver.Click(By.XPath("//div[@class='modal-footer']/button"));
            Driver.ScrollBy(0,0);
        }

        public void ClickButton(string buttonName)
        {
            Driver.FindElementXpath("//a[text()='"+ buttonName + "']").Click();
        }
        
        public bool VerifyCartPage()
        {
            return Driver.FindElementXpath("//li[@class='active']").Displayed;
        }
        
        public void ClickProceedCheckout()
        {
            Driver.Click(By.XPath("//a[text()='Proceed To Checkout']"));
        }
        
        public void ClickRegisterAndLogin()
        {
            Driver.Click(By.XPath("//u[text()='Register / Login']"));
        }

        public void FillForm()
        {
            Driver.SendKey(By.XPath("//input[@name='name']"), Faker.Name.First());
            Driver.SendKey(By.XPath("//input[@data-qa='signup-email']"), Faker.Internet.Email());
            Driver.Click(By.XPath("//button[@data-qa='signup-button']"));


            Driver.MoveToElement(By.Id("id_gender1"));
            Driver.SendKey(By.Id("password"), Faker.Internet.UserName());
            Driver.SelectElementFromDropdown(By.Id("days"), "10");
            Driver.SelectElementFromDropdown(By.Id("months"), "February");
            Driver.SelectElementFromDropdown(By.Id("years"), "1996");

            Driver.MoveToElement(By.Id("newsletter"));
            Driver.MoveToElement(By.Id("optin"));

            Driver.ScrollBy(0, 650);

            Driver.SendKey(By.Id("first_name"), Faker.Name.First());
            Driver.SendKey(By.Id("last_name"), Faker.Name.Last());
            Driver.SendKey(By.Id("address1"), Faker.Address.StreetAddress());
            Driver.SelectElementFromDropdown(By.Id("country"), "United States");
            Driver.SendKey(By.Id("state"), Faker.Address.UsState());
            Driver.SendKey(By.Id("city"), Faker.Address.City());
            Driver.SendKey(By.Id("zipcode"), Faker.Address.ZipCode());
            Driver.SendKey(By.Id("mobile_number"), Faker.Phone.Number());

            Driver.Click(By.XPath("//button[text()='Create Account']"));
        }
        public string VerifyThat(string catName)
        {
            return Driver.ElementIsVisible(By.XPath("//h2/b[starts-with(text(),'" + catName + "')]"), 5);
        }
        public bool LoggedControl()
        {
            return Driver.FindElementXpath("//a[contains(text(),' Logged in as ')]").Displayed;
        }
        public string VerifyAdressAndReview(string catName)
        {
            return Driver.ElementIsVisible(By.XPath("//h2[text()='" + catName + "']"),5);
        }
        public void WriteTextArea()
        {

        }

        public void FillPaymentDetails()
        {

        }
    }
}
