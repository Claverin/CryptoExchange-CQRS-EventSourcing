using System;
using System.Linq;
using CryptoExchange.Core.Domain;
using Xunit;

namespace CryptoExchange.Core.Tests.Domain;

public class WalletTests
{
    [Fact]
    public void Create_Should_Initialize_Wallet_And_Add_WalletCreated_Event()
    {
        // Arrange
        var expectedWalletId = Guid.NewGuid();
        var expectedUserId = Guid.NewGuid();

        // Act
        var wallet = Wallet.Create(expectedWalletId, expectedUserId);

        // Assert
        Assert.NotNull(wallet);
        Assert.Equal(expectedWalletId, wallet.Id);
        Assert.Equal(expectedUserId, wallet.UserId);
        Assert.Empty(wallet.Balances);

        // Weryfikacja wewnętrznego notatnika zdarzeń
        Assert.Single(wallet.DomainEvents);

        var domainEvent = wallet.DomainEvents.First();
        Assert.IsType<WalletCreated>(domainEvent);

        var walletCreatedEvent = (WalletCreated)domainEvent;
        Assert.Equal(expectedWalletId, walletCreatedEvent.WalletId);
        Assert.Equal(expectedUserId, walletCreatedEvent.UserId);
        Assert.NotEqual(default, walletCreatedEvent.OccurredOn);
    }
}