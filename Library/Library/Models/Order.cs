using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        [Required]
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [Column(TypeName ="date")]
        public DateTime OrderTime { get; set; }
        [Column(TypeName = "date")]
        public DateTime DeadLine { get; set; }

        public Person Person { get; set; }
        public Book Book { get; set; }
    }
}
