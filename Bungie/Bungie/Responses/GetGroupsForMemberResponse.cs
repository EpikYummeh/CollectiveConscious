using Bungie.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bungie.Responses
{
    public class GetGroupsForMemberResponse
    {
        [JsonProperty("results")]
        public GroupSearchResults[] Results { get; set; }
    }
}
