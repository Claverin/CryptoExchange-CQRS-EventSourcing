using System;

namespace CryptoExchange.Core.Domain;

public class FundsDeposited : IDomainEvent
{
    public Guid Id { get; }
    public DateTime OccurredOn { get; }
    public Guid WalletId { get; }
    public string Currency { get; }
    public decimal Amount { get; }

    public FundsDeposited(Guid id, Guid walletId, string currency, decimal amount, DateTime occurredOn)
    {
        Id = id;
        WalletId = walletId;
        Currency = currency;
        Amount = amount;
        OccurredOn = occurredOn;
    }
}