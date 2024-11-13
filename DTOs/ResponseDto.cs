namespace MyBankBack.DTOs
{
    public record ResponseDto(
        string Token,
        string Name,
        string Cpf
    );
}