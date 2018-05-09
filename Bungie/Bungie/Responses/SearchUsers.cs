using Bungie.Models;
using Newtonsoft.Json;

namespace Bungie.Responses
{
    public class SearchUsersResponse
    {
        [JsonProperty("data")]
        public GeneralUser Response { get; set; }
    }
}
