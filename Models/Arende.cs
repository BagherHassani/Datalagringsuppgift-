using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift1Datalagring.Models
{
    internal class Arende
    {
        public string Kund { get; set; } = null!;
        public string Rubrik { get; set; } = null!;
        public string Beskrivning { get; set; } = null!;
        public DateTime Datum { get; set; } 
        public DateTime DatumChange { get; set; } 
        public string Status { get; set; } = null!;
    }
}
