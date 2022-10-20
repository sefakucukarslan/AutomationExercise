using AutomationExercise.Models;
using AutomationExercise.Steps.BaseSteps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        [StepDefinition(@"Verify 'New User Signup!' is visible")]
        public void SignUpIsVisible()
        {
            Assert.AreEqual(model.SignUpIsVisible(), "New User Signup!");
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
        
        [StepDefinition(@"Verify that 'ENTER ACCOUNT INFORMATION' is visible")]
        public void EnterAccountControl()
        {
            Assert.IsTrue(model.EnterAccountControl().Contains("ENTER ACCOUNT INFORMATION"));
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
        
        [StepDefinition(@"Verify that 'ACCOUNT CREATED!' is visible")]
        public void AccountCreatedIsVisible()
        {
            model.AccountCreatedIsVisible();
        }
        
        [StepDefinition(@"Click 'Continue' button")]
        public void ContinueClick()
        {
            model.ContinueClick();
        }
        
        [StepDefinition(@"Verify that 'Logged in as username' is visible")]
        public void LoggedControl()
        {
            model.LoggedControl();
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

    }
}
