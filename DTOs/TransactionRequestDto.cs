namespace MyBankBack.DTOs
{
    public record TransactionRequestDto(
        long AccountId,
        long CardId,
        double Amount,
        string PaymentDescription,
        DateTime TransactionDate
    );
}