using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;
        }
        public int OrderItemID { get; private set;}
        public int Quantity { get; set;}
        public int ProductID { get; set;}
        public decimal? BuyPrice { get; set;}

        // get one order item
        public OrderItem Get(int orderItemID)
        {
            //code that provides defined order item
            return new OrderItem();
        }

        // save current order item
        public bool Save()
        {
            // code that saves defined order item
            return true;
        }

        // check order item data
        public bool Validate()
        {
            var correct = true;

            if (Quantity <= 0)
                correct = false;
            if (ProductID <= 0)
                correct = false;
            if (BuyPrice == null)
                correct = false;

            return correct;
        }
    }
}
