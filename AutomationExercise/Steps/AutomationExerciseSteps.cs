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

        [StepDefinition(@"Click on 'Signup / Login' button")]
        public void LoginClick()
        {
            model.LoginClick();
        }
        
        [StepDefinition(@"Verify '(.*)' is visible")]
        public void VerifyIsVisible(string catName)
        {
            Assert.IsNull(model.VerifyIsVisible(catName));
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
        public void VerifyThat(string catName)
        {
            Assert.IsNull(model.VerifyThat(catName),"Element Not Found!!");
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
        
        
        [StepDefinition(@"Enter incorrect email address and password")]
        public void IncorrectInformation()
        {
            model.IncorrectInformation();
        }
        
        [StepDefinition(@"Verify error '(.*)' is visible")]
        public void VerifyError(string catName)
        {
            Assert.IsNull(model.VerifyError(catName));
        }  
    }
}
