using System;
using System.Collections.Generic;

namespace Conventional.Samples.Domain
{
    public class Attendee : IAggregateRoot
    {
        protected Attendee()
        {
        }

        protected Attendee(Guid id)
        {
            Id = id;
        }

        public static Attendee Create(Guid id)
        {
            return new Attendee(id);
        }

        public Guid Id { get; private set; }

        public IEnumerable<Booking> Bookings { get; private set; } = new List<Booking>();
    }
}