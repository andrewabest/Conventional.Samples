using System;
using System.Collections.Generic;
using System.Linq;
using Conventional.Samples.Housekeeping;
using Conventional.Samples.Humans.Dtos;

namespace Conventional.Samples.Danger.Queries
{
    public class AttendeesQuery : IQuery
    {
        private readonly Func<DbContext> _contextFactory;

        public AttendeesQuery(Func<DbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public IEnumerable<AttendeeInformationDto> Execute()
        {
            return

                _contextFactory().Attendees.Select(
                    x =>
                        new AttendeeInformationDto
                        {
                            Bookings = x.Bookings.Select(b => new BookingInformationDto(b.Id, b.Description)).ToArray()
                        });
        } 
    }
}