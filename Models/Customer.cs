using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift1Datalagring.Models
{
    internal class Customer
    {
        public string Name{ get; set; } = null!;
        
        public string Email { get; set; } = null!;
        public int telefonummer { get; set; }
        public int Mobilenummer { get; set; }
      
       public Arende Arende{ get; set; } = null!;
        public Adress Adress { get; set; } = null!;
    }
}
