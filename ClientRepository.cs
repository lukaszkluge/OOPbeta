using System;

public class ClientRepository
{
    // save current client
    public bool Save()
    {
        return true;
    }

    //download new client
    public Client Get(int ClientID)
    {
        // we create client class instance
        Client client = new Client(ClientID);


        // temporarily encoded values ​​to return to the client
        if (ClientID == 1)
        {
            client.Email = "eminem.stan@detroit.com";
            client.Name = "Luke";
            client.Surname = "Skycoder";
        }

        return new Client();
    }

    public List<Client> GetClients()
    {
        // get all clients
        return new List<Client>();
    }
}
