using System.Collections.Generic;
using Conventional.Samples.Domain;

namespace Conventional.Samples.Danger
{
    /// <summary>
    /// A mock version of https://msdn.microsoft.com/en-us/library/system.data.entity.dbcontext(v=vs.113).aspx
    /// </summary>
    public class DbContext
    {
        public IEnumerable<Attendee> Attendees { get; } = new List<Attendee>();
        public IEnumerable<Booking> Bookings { get; } = new List<Booking>();
    }
}