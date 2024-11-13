using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBankBack.DTOs
{
    public record BuyWithCardDto(
        long CardId,
        double PurchaseAmount,
        string CardPassword,
        string AccountCpf,
        string PaymentDescription
    );
    
}