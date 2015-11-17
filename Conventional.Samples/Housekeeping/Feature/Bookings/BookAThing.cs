using System;
using System.Collections.Generic;
using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Commands;
using MediatR;

namespace Conventional.Samples.Housekeeping.Feature.Bookings
{
    public class BookAThing
    {
        private readonly IMediator _mediator;

        public BookAThing(IMediator mediator)
        {
            _mediator = mediator;
        }

        public List<Booking> Bookings { get; } = new List<Booking>();

        public void Initialize()
        {
            Bookings.AddRange(_mediator.Send(new ListBookingsByDateRequest(DateTime.Now)));
        }

        public void DoMyThing()
        {
            new SaveBookingCommand().Execute();
        }
    }
}