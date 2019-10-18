using System;
using System.Threading;
using System.Threading.Tasks;
using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Requests;
using MediatR;

namespace Conventional.Samples.Humans.Handlers
{
    public class ListBookingsByDateRequestHandler : IRequestHandler<ListBookingsByDateRequest, Booking[]>
    {
        public Task<Booking[]> Handle(ListBookingsByDateRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Array.Empty<Booking>());
        }
    }
}