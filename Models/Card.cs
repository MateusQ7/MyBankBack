using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBankBack.Models
{
    [Table("cards")]
    public class Card
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string CardName { get; set; } = string.Empty;
        [Required]
        public string CardNumber { get; set; } = string.Empty;
        [Required]
        public string CardPassword { get; set; } = string.Empty;
        [Required]
        public string Cvv { get; set; } = string.Empty;
        [Required]
        private double CardValue { get; set; }
        [Required]
        private string? ExpirationDate { get; set; }
        [Required]
        private string CardStatus { get; set; } = string.Empty;
        [Required]
        public bool IsActive { get; set; } = true;

        [ForeignKey("AccountId")]
        public virtual Account? Account { get; set; }
    }
}