using System.Security;

namespace ABC.BL
{
    public class Client
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int ClientID { get; private set; }

        public string? NameSurname
        {
            get
            {
                return Name + ", " + Surname;
            }
        }
    }
}
