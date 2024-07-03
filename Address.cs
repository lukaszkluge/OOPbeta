namespace ABC.BL
{
  
        public class Address
        {
            public Address()
            {
                
            }

            public Address(int addressID)
            {
                AddressID = addressID;
            }

            public int AddressID { get; private set; }
            public int AddressType { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public string Couuntry { get; set; }
    }
    
}
