using System;
using Conventional.Samples.Domain;
using MediatR;

namespace Conventional.Samples.Housekeeping.Requests
{
    public class ListBookingsByDateRequest : IRequest<Booking[]>
    {
        public DateTime DateTime { get; set; }

        public ListBookingsByDateRequest(DateTime dateTime)
        {
            DateTime = dateTime;
        }
    }
}