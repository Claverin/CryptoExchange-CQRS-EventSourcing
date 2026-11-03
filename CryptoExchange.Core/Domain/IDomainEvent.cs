using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoExchange.Core.Domain
{
    public interface IDomainEvent
    {
        Guid id { get; }
        DateTime OccurredOn { get; }
    }
}
