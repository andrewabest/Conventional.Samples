using Conventional.Samples.Training;
using NUnit.Framework;
using Conventional.Samples.Training.External;

namespace Conventional.Samples.Tests.Training
{
    public class TrainingConventions
    {
        [Test]
        public void AsyncMethodsMustNotBeVoid()
        {
            typeof (BookingProcessor).Assembly.ExportedTypes
                .MustConformTo(Convention.VoidMethodsMustNotBeAsync)
                .WithFailureAssertion(Assert.Fail);
        }

        [Test]
        public void AsyncMethodsNamesMustEndInAsync()
        {
            typeof(BookingProcessor).Assembly.ExportedTypes
                .MustConformTo(Convention.AsyncMethodsMustHaveAsyncSuffix)
                .WithFailureAssertion(Assert.Fail);
        }

        [Test]
        public void AsyncLibrariesMustCallConfigureAwaitFalse()
        {
            typeof (BookingClient)
                .MustConformTo(Convention.LibraryCodeShouldCallConfigureAwaitWhenAwaitingTasks)
                .WithFailureAssertion(Assert.Fail);
        }
    }
}