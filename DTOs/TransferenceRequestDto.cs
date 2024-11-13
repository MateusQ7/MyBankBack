using MyBankBack.Models.Enums;

namespace MyBankBack.DTOs
{
    public record TransferRequestDto(
        string CpfSender,
        string CpfReceiver,
        double Amount,
        string ConfirmPasswordaymentDescription,
        Transferences TransferenceType);
}