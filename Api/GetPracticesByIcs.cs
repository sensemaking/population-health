using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Sensemaking.Query.Dapper;
using Sensemaking.Web.Api;

namespace Fdb.PopulationHealth.Api
{
    public class GetPracticesByIcs : IHandleGetRequests
    {
        private const string IcsRouteKey = "ics";

        public string Route => $"/{{{IcsRouteKey}}}";

        public Task<object> Handle(RequestParameters parameters)
        {
            return Task.FromResult<object>(new Query().GetResults(new Request(parameters.Values[IcsRouteKey].ToString())));
        }

        public class Request
        {
            public Request(string ics)
            {
                Ics = ics;
            }

            public string Ics { get; }
        }
        
        public class Query : Query<Request, HitCount>
        {
            public override HitCount[] GetResults(Request parameters)
            {
               return database.Query<HitCount>("select * from RuleHitCount where Ics = @ics", new { parameters.Ics }).ToArray();
            }
        }
    }

    public class HitCount
    {
        public string Practice { get; } = null!;
        public string Name { get; } = null!;
        public string Description { get; } = null!;
        public int Count { get; }
        public string Ics { get; } = null!;
    }
}