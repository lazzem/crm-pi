using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Facture
    {
        [Key]
        [Column(Order =0)]
        public string DateAchat { get; set; }
        [ForeignKey("ClientFK")]
        [Key]
        [Column(Order = 1)]
        public Client Client { get; set; }
        public int ClientFK { get; set; }
        [ForeignKey("ProductFK")]
        [Key]
        [Column(Order = 2)]
        public Product Product { get; set; }
        public int ProductFK { get; set; }
    }
}
