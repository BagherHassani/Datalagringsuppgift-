using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift1Datalagring.Models
{
    [Index(nameof(Email), IsUnique = true)]
    internal class CustomerEntity
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [StringLength(50)]
        public string Name{ get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [ Required]
        [StringLength(11)]
        public int Telefonummer { get; set; }

        [ Required]
        [StringLength(11)]
        public int Mobilenummer { get; set; }

        [Required]
        
       public int AdressId { get; set; }

      

       
       

        public virtual AdressEntity Adress{ get; set; } = null!;
        public virtual ArendeEntity Arende { get; set; } = null!;
    }
}
