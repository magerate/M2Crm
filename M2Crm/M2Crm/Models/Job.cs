using System;

namespace Pasasoft.Crm.Models
{
    public class Job
    {
        public Job()
        {
            CreateTime = DateTime.Now;
            Location = new Address()
            {
                Street = "233 E Harris Ave",
                City = "LA",
                State = "CA",
                ZipCode = "783000",
            };
        }

        public string Name { get; set; }
        public string Status { get; set; }

        public Customer Customer { get; set; }
        public Address Location { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
