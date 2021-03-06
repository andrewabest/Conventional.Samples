﻿using Conventional.Samples.Housekeeping.Requests;
using Conventional.Samples.Tests.Extensions;
using MediatR;
using NUnit.Framework;

namespace Conventional.Samples.Tests.Housekeeping
{
    public class HousekeepingConventions
    {
        [Test]
        public void RequestsMustLiveInRequestsNamespace()
        {
            typeof (ListBookingsByDateRequest).Assembly
                .GetAllTypesImplementingOpenGenericType(typeof(IRequest<>))
                .MustConformTo(Convention.MustLiveInNamespace("Conventional.Samples.Housekeeping.Requests"))
                .WithFailureAssertion(Assert.Fail);
        }

        [Test]
        public void RequestsNamesMustEndInRequest()
        {
            typeof(ListBookingsByDateRequest).Assembly
                .GetAllTypesImplementingOpenGenericType(typeof(IRequest<>))
                .MustConformTo(Convention.NameMustEndWith("Request"))
                .WithFailureAssertion(Assert.Fail);
        }
    }
}