using System;
using System.Threading.Tasks;
using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Requests;
using Conventional.Samples.Humans.Dtos;
using MediatR;

namespace Conventional.Samples.Training.External
{
    public class BookingClient
    {
        private readonly IMediator _mediator;

        public BookingClient(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Booking[]> GetBookingsAsync(DateTime bookingDate)
        {
            return await _mediator.Send(new ListBookingsByDateRequest(bookingDate)).ConfigureAwait(false);
        } 
    }
}