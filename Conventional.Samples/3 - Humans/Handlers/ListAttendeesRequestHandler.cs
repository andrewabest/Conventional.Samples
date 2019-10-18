using System;
using System.Threading;
using System.Threading.Tasks;
using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Requests;
using MediatR;

namespace Conventional.Samples.Humans.Handlers
{
    public class ListAttendeesRequestHandler : IRequestHandler<ListAttendeesRequest, Attendee[]>
    {
        public Task<Attendee[]> Handle(ListAttendeesRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Array.Empty<Attendee>());
        }
    }
}