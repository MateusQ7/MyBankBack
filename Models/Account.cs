using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBankBack.Models
{
    [Table("account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [StringLength(11)]
        public string? Cpf { get; set; } = string.Empty;

        [Required]
        public double? CreditLimit { get; set; }
        [Required]
        public double? AccountValue { get; set; }
        [Required]
        public double? UsedLimit { get; set; }

        [ForeignKey("Cpf")]
        public virtual User? User { get; set; }

        public virtual ICollection<Card> Cards { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public Account()
        {
            Cards = new HashSet<Card>();
            Invoices = new HashSet<Invoice>();
        }

    }
}