using AutomationExercise.WebDriver;
using OpenQA.Selenium;

namespace AutomationExercise.Models
{
    public class ContactUsFormModel
    {
        public void ClickContactUs(string link)
        {
            Driver.Click(By.XPath("//a[text()='"+ link +"']"));
        }
        public string IsVisible(string title)
        {
            return Driver.ElementIsVisible(By.XPath("//h2[starts-with(text(),'" + title + "')]"), 5);
        }

        public void EnterInformation()
        {
            Driver.SendKey(By.XPath("//input[@name='name']"), Faker.Name.First());
            Driver.SendKey(By.XPath("//input[@name='email']"), Faker.Internet.Email());
            Driver.SendKey(By.XPath("//input[@name='subject']"), Faker.Lorem.Sentence());
            Driver.SendKey(By.Id("message"), Faker.Lorem.Paragraph());

        }

        public void UploadFile()
        {
            Driver.SendKey(By.XPath("//input[@type='file']"), @"C:\Users\autum\Desktop\selenium.png");
        }

        public void ClickSubmitButton()
        {
            Driver.Click(By.XPath("//input[@name='submit']"));
        }

        public void ClickOkButton()
        {
            Driver.AlertAccept();
        }

        public string VerifySuccessMessage(string catName)
        {
            return Driver.ElementIsVisible(By.XPath("//div[starts-with(text(),'" + catName + "')]"), 5);
        }

        public void ClickHome()
        {
            Driver.Click(By.XPath("//span[text()=' Home']"));
        }
    }
}
