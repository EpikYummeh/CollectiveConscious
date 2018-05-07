namespace Bungie
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BaseJump;
    using Responses;

    [Route("https://www.bungie.net/platform/Destiny/")]
    public class DService : BungieService, IDService
    {
        public DService(string apiKey) : 
            base(apiKey)
        {

        }
        [Route("Advisors/v2/")]
        public Task<GetAdvisorsV2Response> GetAdvisorsv2(bool? definitions = null)
        {
            var model = new
            {
                definitions
            };
            return Request<GetAdvisorsV2Response>(model);
        }
    }
}
