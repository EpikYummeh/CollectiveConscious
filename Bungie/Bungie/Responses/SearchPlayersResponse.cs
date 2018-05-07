namespace Bungie.Responses
{
    using System.Collections.Generic;
    using Models;
    using Newtonsoft.Json;

    public class SearchPlayersResponse : List<UserInfo>
    {
        [JsonProperty("data")]
        public Account MembershipId { get; set; }
    }
}