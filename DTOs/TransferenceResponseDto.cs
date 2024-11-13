using MyBankBack.Models.Enums;

namespace MyBankBack.DTOs
{
    public record TransferResponseDto(
        long Id,
        string CpfSender,
        string SenderName,
        string CpfReceiver,
        string ReceiverName,
        double Amount,
        string PaymentDescription,
        DateTime TransferenceDate,
        Transferences TransactionType
    );
}