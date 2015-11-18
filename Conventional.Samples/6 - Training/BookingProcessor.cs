using System.Net.Http;
using System.Threading.Tasks;
using Conventional.Samples.Domain;

namespace Conventional.Samples.Training
{
    public class BookingProcessor
    {
        public async Task ProcessAsync(Booking booking)
        {
            string content;
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("http://www.readify.net");

                content = await result.Content.ReadAsStringAsync();
            }

            // Todo: Do things with content!
        }
    }
}