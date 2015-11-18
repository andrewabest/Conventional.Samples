using System;
using Conventional.Samples.Domain;
using MediatR;

namespace Conventional.Samples.Training.Requests
{
    public class ListBookingsByDateRequestAsync : IAsyncRequest<Booking[]>
    {
        public DateTime DateTime { get; set; }

        public ListBookingsByDateRequestAsync(DateTime dateTime)
        {
            DateTime = dateTime;
        }
    }
}