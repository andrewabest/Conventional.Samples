using System;
using Conventional.Samples.Domain.ValueTypes;

namespace Conventional.Samples.Domain
{
    public class Booking : IAggregateRoot
    {
        protected Booking()
        {
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

        public Guid Id { get; private set; }

        public Money Cost { get; private set; }

        public string Description { get; set; }

        public void SetDescription(string description)
        {
            Description = description;
        }
    }
}