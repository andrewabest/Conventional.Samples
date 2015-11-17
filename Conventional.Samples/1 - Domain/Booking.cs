using System;
using Conventional.Samples.Domain.ValueTypes;

namespace Conventional.Samples.Domain
{
    public class Booking : IAggregateRoot
    {
        protected Booking()
        {
            Cost = Money.Empty();
        }

        protected Booking(Guid id, Money cost)
        {
            Id = id;
            Cost = cost;
        }

        public static Booking Create(Guid id, decimal cost)
        {
            return new Booking(id, Money.Create(cost));
        }

        public Guid Id { get; }

        public Money Cost { get; }

        public string Description { get; private set; }

        public void SetDescription(string description)
        {
            Description = description;
        }
    }
}