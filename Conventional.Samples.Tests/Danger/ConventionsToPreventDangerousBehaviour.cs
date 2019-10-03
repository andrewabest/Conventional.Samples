using System.Linq;
using Conventional.Samples.Danger;
using Conventional.Samples.Humans.Dtos;
using NUnit.Framework;

namespace Conventional.Samples.Tests.Danger
{
    public class ConventionsToPreventDangerousBehaviour
    {
        [Test]
        public void DtosShouldEagerlyEvaluateEnumerables()
        {
            typeof (AttendeeInformationDto).Assembly.GetExportedTypes()
                .Where(x => x.Namespace != null && x.Namespace.EndsWith(".Dtos"))
                .MustConformTo(Convention.EnumerablePropertiesMustBeEagerLoadedConventionSpecification)
                .WithFailureAssertion(Assert.Fail);
        }

        [Test]
        public void MustNotTakeDirectDependencyOnDbContext()
        {
            typeof (DbContext).Assembly.GetExportedTypes()
                .MustConformTo(Convention.MustNotTakeADependencyOn(typeof (DbContext),
                    "Because multithreading, transaction boundaries, testability etc."))
                .WithFailureAssertion(Assert.Fail);
        }
    }
}