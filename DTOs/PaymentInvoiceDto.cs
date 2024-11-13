namespace MyBankBack.DTOs
{
    public record PaymentInvoiceDto(
        string AccountCpf,
        double PayValue
    );

}