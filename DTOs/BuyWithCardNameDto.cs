namespace MyBankBack.DTOs
{
    public record BuyWithCardNameDto(
        string CardName,
        double PurchaseAmount,
        string CardPassword,
        string AccountCpf,
        string PaymentDescription
    );
}