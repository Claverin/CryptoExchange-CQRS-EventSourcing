using System;

namespace CryptoExchange.Core.Domain;

public interface IDomainEvent
{
    Guid Id { get; }
    DateTime OccurredOn { get; }
}