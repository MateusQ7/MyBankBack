namespace MyBankBack.DTOs
{
    public record LoginRequestDto(
        string Email,
        string Password
    );
}