using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
   public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string BookName { get; set; }
        [Required]
        [MaxLength(50)]
        public string AuthorFullName { get; set; }
        [Column(TypeName ="date")]
        public DateTime? WriteDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        public int Count { get; set; }
    }
}
