using System.Security;

namespace ABC.BL
{
    public class Client
    {
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
    }
}
