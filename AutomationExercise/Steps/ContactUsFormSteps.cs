using TechTalk.SpecFlow;
using AutomationExercise.Steps.BaseSteps;
using AutomationExercise.Models;
using NUnit.Framework;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature = "ContactUsForm")]
    public class ContactUsFormSteps : BaseStep
    {
        ContactUsFormModel model = new ContactUsFormModel();

        [StepDefinition(@"Click on '(.*)' button")]
        public void ClickContactUs(string link)
        {
            model.ClickContactUs(link);
        }
        
        [StepDefinition(@"Verify '(.*)' is visible")]
        public void IsVisible(string title)
        {
            Assert.IsNull(model.IsVisible(title),"Element Not Found!!");
        }

        [StepDefinition(@"Enter name, email, subject and message")]
        public void EnterInformation()
        {
            model.EnterInformation();
        }

        [StepDefinition(@"Upload file")]
        public void UploadFile()
        {
            model.UploadFile();
        }

        [StepDefinition(@"Click Submit button")]
        public void ClickSubmitButton()
        {
            model.ClickSubmitButton();
        }

        [StepDefinition(@"Click OK button")]
        public void ClickOkButton()
        {
            model.ClickOkButton();
        }

        [StepDefinition(@"Verify success message '(.*)' is visible")]
        public void VerifySuccessMessage(string catName)
        {
            model.VerifySuccessMessage(catName);
        }

        [StepDefinition(@"Click Home button")]
        public void ClickHome()
        {
            model.ClickHome();
        }

    }
}
