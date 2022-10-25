using AutomationExercise.Models;
using AutomationExercise.Steps.BaseSteps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding,Scope(Feature = "ProductsInCart")]
    public class ProductsInCartSteps : BaseStep
    {
        ProductsInCartModel model = new ProductsInCartModel();

        [StepDefinition(@"Click Products button")]
        public void ClickProducts()
        {
            model.ClickProducts();
        }
        
        [StepDefinition(@"Hover over first product and click Add to cart")]
        public void FirstProductAdd()
        {
            model.ProductAdd();
        }
        
        [StepDefinition(@"Click '(.*)' button")]
        public void ClickContinue(string text)
        {
            model.ClickContinue(text);
        }
        
        [StepDefinition(@"Hover over second product and click Add to cart")]
        public void HoverProductAdd()
        {
            model.HoverProductAdd();
        }
        
        [StepDefinition(@"Click View Cart button")]
        public void ClickViewCart()
        {
            model.ClickViewCart();
        }
        
        [StepDefinition(@"Verify both products are added to Cart")]
        public void VerifyProducts()
        {
            Assert.AreEqual(model.VerifyProducts(),2);
        }
        
        [StepDefinition(@"Verify their prices, quantity and total price")]
        public void VerifyProductInformation()
        {
            Assert.AreEqual(model.VerifyProductPrice(),2);
            Assert.AreEqual(model.VerifyProductQuantity(),2);
            Assert.AreEqual(model.VerifyProductTotal(),2);
        }

    }
}
