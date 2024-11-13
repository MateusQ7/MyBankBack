namespace MyBankBack.DTOs
{
    public record InvoiceRequestDto(
        string InvoiceDescription,
        double Amount,
        DateTime InvoiceDate,
        string InvoiceStatus,
        long Id,
        DateTime DueDate,
        string Email
    );
}