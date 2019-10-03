using System;
using Conventional.Samples.Danger;
using FluentAssertions;
using NUnit.Framework;

namespace Conventional.Samples.Tests.Legacy
{
    public class Conventions
    {
        [Test]
        public void MustNotUseDateTimeDirectly()
        {
            typeof(DbContext).Assembly.GetExportedTypes()
                .MustConformTo(Convention.MustNotResolveCurrentTimeViaDateTime)
                .WithFailureAssertion(Assert.Fail);
                
        }

        readonly DateTime _doomsday = new DateTime(2015, 12, 2);

        [Test]
        public void MustNotUseDateTimeDirectly_Alternative()
        {
            // note: doomsday tests require warning and failure assertions to be set up globally
            ConventionConfiguration.DefaultFailureAssertionCallback = Assert.Fail;
            ConventionConfiguration.DefaultWarningAssertionCallback = Assert.Inconclusive;

            typeof(DbContext).Assembly.GetExportedTypes()
                .WithKnownOffenders(1)
                .ByDoomsday(_doomsday)
                .WithWarningWithin(TimeSpan.FromDays(14))
                .WithMessage("DateTime.Now must not be used directly")
                .MustConformTo(Convention.MustNotResolveCurrentTimeViaDateTime);
        }
    }
}