using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift1Datalagring.Models
{
    internal class Adress
    {
        public string StreetName { get; set; } = null!;
        public String PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;

    }
}
