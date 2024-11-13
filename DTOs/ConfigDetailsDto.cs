namespace MyBankBack.DTOs
{
    public record ConfigDetailsDto(
        string Cpf,
        string Phone,
        string Email,
        string Password,
        string ConfirmPassword
    );
}