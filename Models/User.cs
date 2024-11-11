using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBankBack.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Cpf { get; set; }

        [Required]
        public DateTime? Birthdate { get; set; }

        [ForeignKey("Cpf")]
        public virtual Account? Account { get; set; }

        public User(RegisterRequestDto registerRequestDto)
        {
            Name = registerRequestDto.Name;
            Email = registerRequestDto.Email;
            Password = registerRequestDto.Password;
            Phone = registerRequestDto.Phone;
            Cpf = registerRequestDto.Cpf;
            Birthdate = registerRequestDto.Birthdate;
        }

        public User() { }
    }
}
