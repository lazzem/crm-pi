using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Product
    {
        [DataType(DataType.Date)]
        [Display(Name="Production Date")]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Veuillez entrer un nom valide !")]
        [StringLength(25,ErrorMessage ="Ne doit pas depassé 25 caractéres!")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public string Image { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Production Date")]
        public int ProductId { get; set; }
        [Range(0,int.MaxValue,ErrorMessage ="Veuillez entrer une quantité valide!")]
        public int Quantity { get; set; }
        public virtual ICollection<Provider> ProviderList { get; set; }
        public virtual Category Categorie { get; set; }
        [ForeignKey("Categorie")]
        public int? CategoryId { get; set; }
        public virtual ICollection<Facture> Factures { get; set; }

    }
}
