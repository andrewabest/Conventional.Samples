using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Requests;
using MediatR;

namespace Conventional.Samples.Humans.Handlers
{
    public class ListBookingsByDateRequestHandler : IRequestHandler<ListBookingsByDateRequest, Booking[]>
    {
        public Booking[] Handle(ListBookingsByDateRequest message)
        {
            return new Booking[0];
        }
    }
}