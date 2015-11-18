using Conventional.Samples.Domain;
using Conventional.Samples.Humans.Handlers;

namespace Conventional.Samples.Opinions
{
    public class BookingAlgorithm
    {
        public decimal Compute(Booking booking)
        {
            var result = booking.Cost.Amount * 2;

            return result;
        }
    }
}