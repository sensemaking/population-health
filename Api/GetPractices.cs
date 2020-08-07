using System.Linq;
using System.Threading.Tasks;
using Sensemaking.Query.Dapper;
using Sensemaking.Web.Api;

namespace Fdb.PopulationHealth.Api
{
    public class GetPractices : IHandleGetRequests
    {
        public string Route => "/";

        public Task<object> Handle(RequestParameters parameters)
        {
            return Task.FromResult<object>(new Query().GetResults(new Request()));
        }

        public class Request { }
        
        public class Query : Query<Request, HitCount>
        {
            public override HitCount[] GetResults(Request parameters)
            {
                return database.Query<HitCount>("select * from RuleHitCount").ToArray();
            }
        }
    }

    public class HitCount
    {
        public string Practice { get; } = null!;
        public string Name { get; } = null!;
        public string Description { get; } = null!;
        public int Count { get; }
    }
}