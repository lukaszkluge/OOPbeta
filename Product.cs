using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    internal class Product
    {
        public Product()
        {

        }

        public Product(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; private set; }
        public Decimal? ActualPrice { get; set; }
        public string? Description { get; set; }
        public string? ProductName { get; set; }

        // get one product
        public Product Get(int productID) 
        {
            //code that provides defined product
            return new Product();
        }

        // save current product
        public bool Save()
        {
            // code that saves defined product
            return true;
        }

        // check product data
        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrEmpty(ProductName))
                correct = false;

            return correct;
        }
    }
}
