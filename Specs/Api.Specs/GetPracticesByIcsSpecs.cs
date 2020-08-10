using NUnit.Framework;

namespace Fdb.PopulationHealth.Api.Specs
{
    public partial class GetPracticesByIcsSpecs
    {
        [Test]
        public void can_retreive_practices_by_ics()
        {
            Given(an_ics);
            When(handling);
            Then(its_practices_are_provided);
            And(they_have_their_description);
            And(they_have_their_hit_count);
        }
    }
}