using System.Collections.Generic;
using System.Linq;
using Conventional.Samples.Housekeeping;
using Conventional.Samples.Humans.Dtos;

namespace Conventional.Samples.Danger.Queries
{
    public class AttendeesQuery : IQuery
    {
        private readonly DbContext _context;

        public AttendeesQuery(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<AttendeeInformationDto> Execute()
        {
            return

                _context.Attendees.Select(
                    x =>
                        new AttendeeInformationDto
                        {
                            Bookings = x.Bookings.Select(b => new BookingInformationDto(b.Id, b.Description))
                        });
        } 
    }
}