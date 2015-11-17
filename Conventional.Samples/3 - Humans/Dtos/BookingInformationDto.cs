using System;

namespace Conventional.Samples.Humans.Dtos
{
    public class BookingInformationDto
    {
        protected BookingInformationDto()
        {
        }

        public BookingInformationDto(Guid id, string description)
        {
            Id = id;
            Description = description;
        }


        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}