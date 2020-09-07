using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChangeFeedSample
{
    public class Customer
    {
        public string id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Address addressDetail { get; set; }

        public string postCode { get; set; }
    }
}
