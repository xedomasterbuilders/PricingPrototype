using PricingPrototype.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Core;
using TechTalk.SpecFlow;

namespace PricingSpec
{
    [Binding]
    public class PricingSteps
    {
        public PricingSteps()
        {
            _productPriceController = new ProductPriceController();
        }

        private ProductPriceController _productPriceController;
        private List<string> _selectedProducts = new List<string>();
        private int returnPrice = 0;
       
        [Given(@"I have selected ""(.*)""")]
        public void GivenIHaveSelected(string productName)
        {
            _selectedProducts.Add(productName); 
        }

        [When(@"I request the Product Price")]
        public void WhenIRequestTheProductPrice()
        {
            returnPrice = _productPriceController.GetProductPrice(_selectedProducts[0]);
        }

        [Then(@"The returned price should be (.*)")]
        public void ThenTheReturnedPriceShouldBe(int price)
        {
            NUnitFramework.Assert.AreEqual(price, returnPrice);
        }

        [When(@"I request the Total Price")]
        public void WhenIRequestTheTotalPrice()
        {
            returnPrice = _productPriceController.GetProductPrices(_selectedProducts);
        }


    }
}
