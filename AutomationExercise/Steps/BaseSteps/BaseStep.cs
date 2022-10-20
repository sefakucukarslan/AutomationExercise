using AutomationExercise.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps.BaseSteps
{
    public class BaseStep
    {

        [StepDefinition(@"Launch browser")]
        public void DriverStart()
        {
            Driver.DriverStart();
        }
        
        [StepDefinition(@"Navigate to url '(.*)'")]
        public void GoToUrl(string url)
        {
            Driver.GoToUrl(url);
        }


        [After]
        public void DriverQuit()
        {
            Driver.DriverQuit();
        }
    }
}
