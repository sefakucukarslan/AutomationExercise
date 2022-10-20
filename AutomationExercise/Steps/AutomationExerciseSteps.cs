using AutomationExercise.Models;
using AutomationExercise.Steps.BaseSteps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature ="AutomationExercise")]
    public class AutomationExerciseSteps : BaseStep
    {
        AutomationExerciseModel model = new AutomationExerciseModel();

        [StepDefinition(@"Verify that home page is visible successfully")]
        public void HomePageControl()
        {
            model.HomePageControl();
        }
        
        [StepDefinition(@"Click on 'Signup / Login' button")]
        public void LoginClick()
        {
            model.LoginClick();
        }
        
        [StepDefinition(@"Verify '(.*)' is visible")]
        public void SignUpIsVisible(string catName)
        {
            Assert.AreEqual(model.SignUpIsVisible(), catName);
        }
        
        [StepDefinition(@"Enter name and email address")]
        public void NameEmail()
        {
            model.NameEmail();
        }
        
        [StepDefinition(@"Click 'Signup' button")]
        public void SignUpClick()
        {
            model.SignUpClick();
        }
        
        [StepDefinition(@"Verify that '(.*)' is visible")]
        public void EnterAccountControl(string catName)
        {
            Assert.IsTrue(model.EnterAccountControl().Contains(catName));
        }
        
        [StepDefinition(@"Fill details: Title, Name, Email, Password, Date of birth")]
        public void FillDetails()
        {
            model.FillDetails();
        }
        
        [StepDefinition(@"Select checkbox 'Sign up for our newsletter!'")]
        public void SelectNewsletter()
        {
            model.SelectNewsletter();
        }
        
        [StepDefinition(@"Select checkbox 'Receive special offers from our partners!'")]
        public void SelectReceive()
        {
            model.SelectReceive();
        }
        
        [StepDefinition(@"Fill details: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number")]
        public void AdressInformation()
        {
            model.AdressInformation();
        }
        
        [StepDefinition(@"Click 'Create Account button'")]
        public void CreateAccountClick()
        {
            model.CreateAccountClick();
        }
        
        [StepDefinition(@"Verifyy that '(.*)' is visible")]
        public void AccountCreatedIsVisible(string catName)
        {
            Assert.IsTrue(model.AccountCreatedIsVisible().Contains(catName));
        }
        
        [StepDefinition(@"Click 'Continue' button")]
        public void ContinueClick()
        {
            model.ContinueClick();
        }
        
        [StepDefinition(@"Verify that Logged in as username is visible")]
        public void LoggedControl()
        {
            Assert.IsTrue(model.LoggedControl());
        }
        
        [StepDefinition(@"Click 'Delete Account' button")]
        public void DeleteAccountClick()
        {
            model.DeleteAccountClick();
        }
        
        [StepDefinition(@"Verify that 'ACCOUNT DELETED!' is visible and click 'Continue' button")]
        public void AccountDeletedControl()
        {
            model.AccountDeletedControl();
        }

        
        [StepDefinition(@"Verifyy '(.*)' is visible")]
        public void LoginAccountControl(string catName)
        {
            Assert.AreEqual(model.LoginAccountControl(), catName);
        }
        
        [StepDefinition(@"Enter correct email address and password")]
        public void EnterAccount()
        {
            model.EnterAccount();
        }
        
        [StepDefinition(@"Click 'login' button")]
        public void ClickLoginButton()
        {
            model.ClickLoginButton();
        }
        
        [StepDefinition(@"Verifyyy that '(.*)' is visible")]
        public void AccountDeletedVisible(string catName)
        {
            Assert.AreEqual(model.AccountDeletedVisible(),catName);
        }
    }
}
