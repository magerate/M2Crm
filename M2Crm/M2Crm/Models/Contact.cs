namespace Pasasoft.Crm.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Position { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
