using Conventional.Samples.Domain;
using Conventional.Samples.Humans.Handlers;

namespace Conventional.Samples.Opinions
{
    public class BookingAlgorithm
    {
        // Computes the booking
        public decimal Compute(Booking booking)
        {
            decimal result;

            //if (booking.Description.Contains("Wedding"))
            //{
            //    result = booking.Cost.Amount*10;
            //}

            // Multiply by the standard profit margin of 3
            result = booking.Cost.Amount * 2;

            return result;
        } 
    }
}