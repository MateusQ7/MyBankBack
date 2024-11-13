using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyBankBack.Models.Enums;

namespace MyBankBack.Models
{
    [Table("transference")]
    public class Transference
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [ForeignKey("SenderAccountId")]
        public virtual Account? SenderAccount { get; set; }

        [Required]
        [ForeignKey("ReceiverAccountId")]
        public virtual Account? ReceiverAccount { get; set; }

        public DateTime? TransferenceDate { get; set; }

        [Required]
        public double? Amount { get; set; }

        public string? PaymentDescription { get; set; }

        [Required]
        [EnumDataType(typeof(Transferences))]
        public Transferences? TransferenceType { get; set; }

        [NotMapped]
        public string? SenderAccountCpf => SenderAccount?.Cpf;

        [NotMapped]
        public string? ReceiverAccountCpf => ReceiverAccount?.Cpf;
    }
}
