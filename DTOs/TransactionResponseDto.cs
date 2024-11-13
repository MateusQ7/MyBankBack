namespace MyBankBack.DTOs
{
    public record TransactionResponseDto(
        long Id,
        long AccountId,
        long CardId,
        double Amount,
        string PaymentDescription,
        DateTime TransactionDate
    );
}