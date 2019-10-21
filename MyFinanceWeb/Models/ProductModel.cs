using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinanceWeb.Models
{
    public class ProductModel
    {
        [DataType(DataType.Date)]
        [Display(Name = "Production Date")]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Veuillez entrer un nom valide !")]
        [StringLength(25, ErrorMessage = "Ne doit pas depassé 25 caractéres!")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public string Image { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Veuillez entrer une quantité valide!")]
        public int Quantity { get; set; }
        public int? CategoryId { get; set; }
        public IEnumerable<SelectListItem> cat { get; set; }
    }
}