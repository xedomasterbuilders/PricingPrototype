using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PricingPrototype.Controllers
{
    public class ProductPriceController : ApiController
    {
        private Dictionary<string, int> products = new Dictionary<string, int>();

        public ProductPriceController()
        {
            products.Add("Black Short Jacket", 120);
            products.Add("Black Waistcoat", 40);
            products.Add("Black Tie", 20);
            products.Add("Black Matte Shoes", 20);
        }

        // GET api/productprice/5
        public int Get(string productName)
        {

            return products[productName];
        }

        public int Get(IEnumerable<string> productNames)
        {
            int returnPrice = 0;

            foreach (var prodName in productNames)
            {
                returnPrice += products[prodName];
            }

            return returnPrice;

        }
/*
        // POST api/productprice
        public void Post([FromBody]string value)
        {
        }

        // PUT api/productprice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/productprice/5
        public void Delete(int id)
        {
        }
 */ 
    }
}
