using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        public int BookId { get; set; }

        [Required]
        [MaxLength(20)]
        public  string LibraryCode { get; set; }
        [Column(TypeName ="date")]
        public DateTime? ReciveDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DeadlineDate { get; set; }

        public int BookCount { get; set; }
        
    }
}
