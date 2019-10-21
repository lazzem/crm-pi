using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Mdp et Mdp de confirmation ne sont pas meme!")]
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Key]
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required]
        public string Password { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
    }
}
