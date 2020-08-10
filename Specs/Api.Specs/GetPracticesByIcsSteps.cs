using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Sensemaking.Bdd.Dapper;
using Sensemaking.Web.Api;

namespace Fdb.PopulationHealth.Api.Specs
{
    public partial class GetPracticesByIcsSpecs : DbSpecification
    {
        private GetPracticesByIcs the_handler;
        private string the_ics;
        private HitCount the_response;

        protected override void before_each()
        {
            base.before_each();
            the_handler = null;
            the_ics = null;
            the_response = null;
        }

        private void an_ics()
        {
            the_ics = "myics";
        }

        private void handling()
        {
            the_response = the_handler
                .Handle(new RequestParameters(new ReadOnlyDictionary<string, object>(new Dictionary<string, object>()
                    {{"ics", the_ics}}))).Result as HitCount;
        }

        private void its_practices_are_provided()
        {
            the_response.Name.shou
        }

        private void they_have_their_description()
        {
            throw new System.NotImplementedException();
        }

        private void they_have_their_hit_count()
        {
            throw new System.NotImplementedException();
        }
    }
}