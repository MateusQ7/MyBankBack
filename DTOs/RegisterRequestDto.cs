namespace MyBankBack.DTOs
{
    public record RegisterRequestDto(
        string Name, 
        string Email, 
        string Password, 
        string Phone, 
        string Cpf,
        string Birthdate
    );
}