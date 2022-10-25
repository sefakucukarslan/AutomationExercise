using AutomationExercise.WebDriver;
using OpenQA.Selenium;

namespace AutomationExercise.Models
{
    public class AutomationExerciseModel
    {               
               
        public void LoginClick()
        {
            Driver.FindElementXpath("//a[text()=' Signup / Login']").Click();
        }
        
        public string VerifyIsVisible(string catName)
        {
            return Driver.ElementIsVisible(By.XPath("//h2[contains(text(),'" + catName + "')]"),5);
        }
        
        public void NameEmail()
        {           
            Driver.MoveToElement(By.XPath("//input[@type='text']"));
            Driver.SendKey(By.XPath("//input[@type='text']"), Faker.Name.First());
            Driver.SendKey(By.XPath("//input[@data-qa='signup-email']"), Faker.Internet.Email());
        }

        public void SignUpClick()
        {
            Driver.FindElementXpath("//button[text()='Signup']").Click();
        }
        
        public string VerifyThat(string catName)
        {
            return Driver.ElementIsVisible(By.XPath("//h2/b[starts-with(text(),'" + catName +"')]"),5);           
        }
        
        public void FillDetails()
        {
            By genderElement = By.Id("id_gender1");
            By passwordElement = By.Id("password");
            By daysElement = By.Id("days");
            By monthsElement = By.Id("months");
            By yearsElement = By.Id("years");

            Driver.MoveToElement(genderElement);            
            Driver.SendKey(passwordElement, Faker.Internet.UserName());
            Driver.SelectElementFromDropdown(daysElement, "10");
            Driver.SelectElementFromDropdown(monthsElement, "February");
            Driver.SelectElementFromDropdown(yearsElement, "1996");            
        }

        public void SelectNewsletter()
        {
            Driver.MoveToElement(By.Id("newsletter"));
        }
        
        public void SelectReceive()
        {
            Driver.MoveToElement(By.Id("optin"));
        }
        
        public void AdressInformation()
        {
            By firstNameElement = By.Id("first_name");
            By lastNameElement = By.Id("last_name");
            By address1Element = By.Id("address1");
            By countryElement = By.Id("country");
            By stateElement = By.Id("state");
            By cityElement = By.Id("city");
            By zipcodeElement = By.Id("zipcode");
            By mobile_numberElement = By.Id("mobile_number");

            string firstName = Faker.Name.First();
            string lastName = Faker.Name.Last();
            string address = Faker.Address.StreetAddress();
            string country = "United States";
            string state = Faker.Address.UsState();
            string city = Faker.Address.City();
            string zipcode = Faker.Address.ZipCode();
            string mobile_number = Faker.Phone.Number();
            
            Driver.SendKey(firstNameElement, firstName);
            Driver.SendKey(lastNameElement, lastName);
            Driver.SendKey(address1Element, address);
            Driver.SelectElementFromDropdown(countryElement, country);
            Driver.SendKey(stateElement, state);
            Driver.SendKey(cityElement, city);
            Driver.SendKey(zipcodeElement, zipcode);
            Driver.SendKey(mobile_numberElement, mobile_number);
        }

        public void CreateAccountClick()
        {
            Driver.Click(By.XPath("//button[text()='Create Account']"));
        }
        
        public string AccountCreatedIsVisible()
        {
            return Driver.FindElementXpath("//h2[@class='title text-center']/b").Text;
        }
        
        public void ContinueClick()
        {
            Driver.MoveToElement(By.XPath("//a[@class='btn btn-primary']"));
        }
        
        public bool LoggedControl()
        {
            return Driver.FindElementXpath("//a[contains(text(),' Logged in as ')]").Displayed;
        }
        
        public void DeleteAccountClick()
        {
            Driver.FindElementPartialLinkText("Delete Acco").Click();
        }
        
        public void AccountDeletedControl()
        {
            Driver.ElementIsVisible(By.XPath("//h2[@class='title text-center']/b"), 5);
            Driver.Click(By.XPath("//div[@class='pull-right']/a"));
        }
        
        public string LoginAccountControl()
        {
            return Driver.FindElementXpath("//div[@class='login-form']/h2").Text;
        }
        
        public void EnterAccount()
        {
            Driver.SendKey(By.XPath("//form[@action='/login']/input[2]"), "autumnwinds_54@hotmail.com");
            Driver.SendKey(By.XPath("//form[@action='/login']/input[3]"),"1989270");
        }
        
        public void ClickLoginButton()
        {
            Driver.Click(By.XPath("//button[@data-qa='login-button']"));
        }
        
        public string AccountDeletedVisible()
        {
            return Driver.FindElementXpath("//h2[@class='title text-center']/b").Text;
        }
        
        public void IncorrectInformation()
        {
            Driver.SendKey(By.XPath("//form[@action='/login']/input[2]"), Faker.Internet.Email());
            Driver.SendKey(By.XPath("//form[@action='/login']/input[3]"), Faker.Internet.UserName());
        }
        
        public string VerifyError(string catName)
        {
            return Driver.ElementIsVisible(By.XPath("//p[contains(text(),'" + catName + "')]"), 5);
        }
    }
}
