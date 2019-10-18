using NUnit.Framework;

namespace Conventional.Samples.Tests.Opinions
{
    public class OpinionConventions
    {
        [Test]
        public void ClassesMustOnlyContainToDoOrNoteComments()
        {
            ThisSolution.MustConformTo(Convention.MustOnlyContainToDoAndNoteComments)
                .WithFailureAssertion(Assert.Fail);
        } 
    }
}