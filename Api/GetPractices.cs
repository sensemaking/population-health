using System.Threading.Tasks;
using Sensemaking.Web.Api;

namespace Fdb.PopulationHealth.Api
{
    public class GetPractices : IHandleGetRequests
    {
        public string Route => "/";

        public Task<object> Handle(RequestParameters parameters)
        {
            return Task.FromResult<object>(new { Contents = "Hello World" });
        }
    }
}