using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Sensemaking.Web.Api;

namespace Fdb.PopulationHealth.Api
{
    public class AddHitCount : IHandlePostRequests<HitCount>
    {
        public Task<HttpStatusCode> HandleJson(string json)
        {
            throw new NotImplementedException();
        }

        public string Route { get; }
        public Task<HttpStatusCode> Handle(HitCount payload)
        {
            throw new NotImplementedException();
        }
    }
}
