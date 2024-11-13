using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyBankBack.DTOs;

namespace MyBankBack.Models
{
    [Table("invoice")]
    public class Invoice
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string? InvoiceDescription { get; set; }
        [Required]
        public double? Amount { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }
        [Required]
        public string? InvoiceStatus { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public DateTime? ClosingDate { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account? Account { get; set; }

        public long AccountId { get; set; }

        public Invoice(InvoiceRequestDto invoiceRequestDto)
        {
            InvoiceDescription = invoiceRequestDto.InvoiceDescription;
            Amount = invoiceRequestDto.Amount;
            InvoiceDate = invoiceRequestDto.InvoiceDate;
            InvoiceStatus = invoiceRequestDto.InvoiceStatus;
            DueDate = invoiceRequestDto.DueDate;
            Email = invoiceRequestDto.Email;
        }

        public Invoice() { }
    }
}