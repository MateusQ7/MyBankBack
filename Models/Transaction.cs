using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBankBack.Models
{
    [Table("transactions")]
    public class Transaction
    {
        [Key]
        public long Id { get; set; }

        [Required]  
        public DateTime? TransactionDate { get; set; }

        [Required]  
        public double? Amount { get; set; }

        [Required]  
        [StringLength(255)]
        public string? PaymentDescription { get; set; }

         [Required]
        [ForeignKey("AccountId")]
        public virtual Account? Account { get; set; }

        [Required]
        [ForeignKey("CardId")]
        public virtual Card? Card { get; set; }

        // Construtor
        public Transaction(Account account, Card card, DateTime transactionDate, double amount, string paymentDescription)
        {
            Account = account;
            Card = card;
            TransactionDate = transactionDate;
            Amount = amount;
            PaymentDescription = paymentDescription;
        }

        public Transaction() { }
    }
}
