﻿using System.Security;

namespace ABC.BL
{
    public class Client
    {

        public Client()
        {

        }

        public Client(int clientID)
        {
            ClientID = clientID;
        }

        public static int Numerator { get; set; }


        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int ClientID { get; private set; }

        public string? NameSurname
        {
            get
            {
                string? NameSurname = Name;
                if (!string.IsNullOrEmpty(Surname))
                {
                    if (!string.IsNullOrEmpty(NameSurname))
                    {
                        NameSurname += ", ";
                    }
                    NameSurname += Surname;
                }
                return NameSurname;
            }
        }

        public bool Validate()
        {
            var correct = true;

            if (string.IsNullOrEmpty(Surname))
                correct = false;
            if (string.IsNullOrEmpty(Email))
                correct = false;

            return correct;

        }

        // save current client
        public bool Save()
        {
            return true;
        }

        //download new client
        public Client Get(int ClientID)
        {
            return new Client();
        }

        public List<Client> GetClients() 
        {   
            // get all clients
            return new List<Client>();
        }
    }
}
