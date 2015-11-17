using NUnit.Framework;

namespace Conventional.Samples.Tests
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [SetUp]
        public void Setup()
        {
            ConventionConfiguration.DefaultFailureAssertionCallback = Assert.Fail;
        }
    }
}