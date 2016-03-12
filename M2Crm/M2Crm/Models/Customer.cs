using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasasoft.Crm.Models
{
    public class Customer
    {
        public Contact Contact { get; set; }
        public Address Address { get; set; }
        public Company Company { get; set; }

        public Customer()
        {
            Contact = new Contact();
            Address = new Address();
            Company = new Company();
        }
    }
}
