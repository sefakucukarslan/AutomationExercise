using AutomationExercise.Models;
using AutomationExercise.Steps.BaseSteps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature = "PurchaseOrder")]
    public class PurchaseOrderSteps : BaseStep
    {
        PurchaseOrderModel model = new PurchaseOrderModel();

        [StepDefinition(@"Add products to cart")]
        public void AddProducts()
        {
            model.AddProducts();
        }
        
        [StepDefinition(@"Click '(.*)' button")]
        public void ClickButton(string buttonName)
        {
            model.ClickButton(buttonName);
        }
        
        [StepDefinition(@"Verify that cart page is displayed")]
        public void VerifyCartPage()
        {
            Assert.IsTrue(model.VerifyCartPage());
        }
        
        [StepDefinition(@"Click Proceed To Checkout")]
        public void ClickProceedCheckout()
        {
            model.ClickProceedCheckout();
        }
        
        [StepDefinition(@"Click Register / Login button")]
        public void ClickRegisterAndLogin()
        {
            model.ClickRegisterAndLogin();
        }
        
        [StepDefinition(@"Fill all details in Signup and create account")]
        public void FillForm()
        {
            model.FillForm();
        }

        [StepDefinition(@"Verify that '(.*)' is visible")]
        public void VerifyThat(string catName)
        {
            Assert.IsNull(model.VerifyThat(catName), "Element Not Found!!");
        }

        [StepDefinition(@"Verify that Logged in as username is visible")]
        public void LoggedControl()
        {
            Assert.IsTrue(model.LoggedControl());
        }
        
        [StepDefinition(@"Verify '(.*)'")]
        public void VerifyAdressAndReview(string catName)
        {
            Assert.IsNull(model.VerifyAdressAndReview(catName), "Element Not Found!!");
        }
        
        [StepDefinition(@"Enter description in comment text area")]
        public void WriteTextArea()
        {
            model.WriteTextArea();
        }
        
        [StepDefinition(@"Enter payment details: Name on Card, Card Number, CVC, Expiration date")]
        public void FillPaymentDetails()
        {
            model.FillPaymentDetails();
        }

    }
}
