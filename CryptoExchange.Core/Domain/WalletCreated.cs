using System;

namespace CryptoExchange.Core.Domain;

public class WalletCreated : IDomainEvent
{
    public Guid Id { get; }
    public DateTime OccurredOn { get; }
    public Guid WalletId { get; }
    public Guid UserId { get; }

    public WalletCreated(Guid id, Guid walletId, Guid userId, DateTime occurredOn)
    {
        Id = id;
        WalletId = walletId;
        UserId = userId;
        OccurredOn = occurredOn;
    }
}