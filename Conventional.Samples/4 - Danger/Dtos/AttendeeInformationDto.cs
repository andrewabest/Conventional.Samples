using System.Collections.Generic;

namespace Conventional.Samples.Humans.Dtos
{
    public class AttendeeInformationDto
    {
        public IEnumerable<BookingInformationDto> Bookings { get; set; }  
    }
}