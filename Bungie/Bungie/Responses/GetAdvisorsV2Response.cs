namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;
    public class GetAdvisorsV2Response
    {
        [JsonProperty("data")]
        public Activities Activities { get; set; }
        public ActivityCategory[] ActivityCategories { get; set; }
    }
}
