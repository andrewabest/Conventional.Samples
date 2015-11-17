using System;

namespace Conventional.Samples.Domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; } 
    }
}