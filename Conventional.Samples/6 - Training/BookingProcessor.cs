using System.Net.Http;
using Conventional.Samples.Domain;

namespace Conventional.Samples.Training
{
    public class BookingProcessor
    {
        public async void Process(Booking booking)
        {
            string content;
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("http://www.readify.net");

                content = await result.Content.ReadAsStringAsync();
            }

            // Do things with content!
        }
    }
}