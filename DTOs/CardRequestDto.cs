namespace MyBankBack.DTOs
{
    public record CardRequestDto(
        long CardId,
        double PurchaseAmount,
        string CardPassword,
        string AccountCpf,
        string PaymentDescription
    );
    
}