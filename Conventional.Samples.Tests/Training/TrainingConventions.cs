using System.Linq;
using Conventional.Samples.Training;
using NUnit.Framework;
using Conventional.Extensions;
using Conventional.Samples.Training.External;

namespace Conventional.Samples.Tests.Training
{
    public class TrainingConventions
    {
        [Test]
        public void AsyncMethodsShouldNotBeVoid()
        {
            typeof (BookingProcessor).Assembly.ExportedTypes
                .MustConformTo(Convention.VoidMethodsMustNotBeAsync);
        }

        [Test]
        public void AsyncMethodsNamesShouldEndInAsync()
        {
            typeof(BookingProcessor).Assembly.ExportedTypes
                .MustConformTo(Convention.AsyncMethodsMustHaveAsyncSuffix);
        }

        [Test]
        public void AsyncLibrariesShouldCallConfigureAwaitFalse()
        {
            typeof (BookingClient)
                .MustConformTo(Convention.LibraryCodeShouldCallConfigureAwaitWhenAwaitingTasks);
        }
    }
}