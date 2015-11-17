using System;
using System.Linq;
using Conventional.Conventions;
using Conventional.Samples.Domain;
using Conventional.Samples.Housekeeping.Requests;
using Conventional.Samples.Humans.Dtos;
using Conventional.Samples.Humans.Handlers;
using Conventional.Samples.Tests.Extensions;
using MediatR;
using NUnit.Framework;

namespace Conventional.Samples.Tests.Humans
{
    public class ConventionsToProtectHumans
    {
        [Test]
        public void RequestsMustHaveHandlers()
        {
            var handlers = typeof (ListAttendeesRequestHandler).Assembly
                .GetAllTypesImplementingOpenGenericType(typeof (IRequestHandler<,>))
                .ToArray();

            typeof (ListAttendeesRequest).Assembly
                .GetAllTypesImplementingOpenGenericType(typeof (IRequest<>))
                .MustConformTo(Convention.RequiresACorrespondingImplementationOf(typeof (IRequestHandler<,>), handlers));
        }

        [Test]
        public void MigrationScriptsMustBeEmbedded()
        {
            typeof (Booking).Assembly.MustConformTo(Convention.MustHaveFilesBeEmbeddedResources(".sql"));
        }

        [Test]
        public void DtosMustBeSerializable()
        {
            typeof (BookingInformationDto).MustConformTo(
                Convention.MustHaveAppropriateConstructors.And(
                Convention.PropertiesMustHavePublicSetters));
        }

        [Test]
        public void ReferencedAssembliesMustNotLiveInBinOrObjFolders()
        {
            typeof(Booking).Assembly.MustConformTo(Convention.MustNotReferenceDllsFromBinOrObjDirectories);
        }
    }
}