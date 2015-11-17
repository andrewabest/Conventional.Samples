using Conventional.Samples.Domain;
using MediatR;

namespace Conventional.Samples.Housekeeping.Requests
{
    public class ListAttendeesRequest : IRequest<Attendee[]>
    {
    }
}