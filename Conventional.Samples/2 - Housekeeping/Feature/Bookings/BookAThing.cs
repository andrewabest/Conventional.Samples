using System;
using System.Collections.Generic;
using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Commands;
using Conventional.Samples.Housekeeping.Requests;
using MediatR;

namespace Conventional.Samples.Housekeeping.Feature.Bookings
{
    public class BookAThing
    {
        private readonly IMediator _mediator;
        private readonly Func<DateTime> _dateTimeFactory;

        public BookAThing(IMediator mediator, Func<DateTime> dateTimeFactory)
        {
            _mediator = mediator;
            _dateTimeFactory = dateTimeFactory;
        }

        public List<Booking> Bookings { get; } = new List<Booking>();

        public void Initialize()
        {
            Bookings.AddRange(_mediator.Send(new ListBookingsByDateRequest(_dateTimeFactory())));
        }

        public void DoMyThing()
        {
            new SaveBookingCommand().Execute();
        }
    }
}