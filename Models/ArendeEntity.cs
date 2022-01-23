using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift1Datalagring.Models
{
    internal class ArendeEntity
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Kund { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Rubrik { get; set; } = null!;

        [Required]
        [StringLength(300)]
        public string Beskrivning{ get; set; } = null!;

        [Required]
        public DateTime Datum { get; set; } 

        [Required]
        public DateTime DatumChange { get; set; } 

        [Required]
        [StringLength(100)]
        public string Status{ get; set; } = null!;
        public virtual ICollection<CustomerEntity> Customers { get; set; } = new List<CustomerEntity>();

    }
}
