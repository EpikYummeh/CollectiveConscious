namespace Bungie.Models
{
    public class ActivityDetails
    {
        public long ReferenceId { get; set;}
        public string InstanceId { get; set; }
        public ActivityMode Mode { get; set; }
        public bool IsPrivate { get; set; }
        public long ActivityTypeHashOverride { get; set; }
    }
}
