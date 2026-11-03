using System;
using System.Collections.Generic;

namespace CryptoExchange.Core.Domain;

public class Wallet : AggregateRoot
{
    public Guid UserId { get; private set; }
    public Dictionary<string, decimal> Balances { get; private set; } = new();

    private Wallet() { }

    public static Wallet Create(Guid id, Guid userId)
    {
        var wallet = new Wallet
        {
            Id = id,
            UserId = userId
        };

        return wallet;
    }
}