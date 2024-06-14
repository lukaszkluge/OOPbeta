using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }


        // get one order
        public Order Get(int orderID)
        {
            //code that provides defined product
            return new Order();
        }

        // save current order
        public bool Save()
        {
            // code that saves defined order
            return true;
        }

        // check order data
        public bool Validate()
        {
            var correct = true;

            if (OrderDate == null)
                correct = false;

            return correct;
        }
    }
}
