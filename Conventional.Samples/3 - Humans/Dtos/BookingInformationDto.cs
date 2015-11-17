using System;

namespace Conventional.Samples.Humans.Dtos
{
    public class BookingInformationDto
    {
        protected BookingInformationDto()
        {
        }

        public static BookingInformationDto Create(Guid id, string description)
        {
            return new BookingInformationDto()
            {
                Id = id,
                Description = description
            };
        }


        public Guid Id { get; private set; }
        public string Description { get; private set; }
    }
}