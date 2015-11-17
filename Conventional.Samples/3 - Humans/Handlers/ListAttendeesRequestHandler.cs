using System;
using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Requests;
using MediatR;

namespace Conventional.Samples.Humans.Handlers
{
    public class ListAttendeesRequestHandler : IRequestHandler<ListAttendeesRequest, Attendee[]>
    {
        public Attendee[] Handle(ListAttendeesRequest message)
        {
            return new Attendee[0];
        }
    }
}