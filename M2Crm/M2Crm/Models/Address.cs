using System;


namespace Pasasoft.Crm.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public override string ToString()
        {
            return $"{Street}{Environment.NewLine}{City} {State}, {ZipCode}";
        }
    }
}
