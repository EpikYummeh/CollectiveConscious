using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungie.Models
{
    public class TrialsDisplay
    {
        public string About { get; set; }
        public long ActivityHash { get; set; }
        public long ActivityModeHash { get; set; }
        public string AdvisorTypeCategory { get; set; }
        public long CategoryHash { get; set; }
        public long DestinationHash { get; set; }
        public string Flavor { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }
        public long PlaceHash { get; set; }
        public long PlaylistHash { get; set; }
        public string[] RecruitmentIds { get; set; }
        public string Status { get; set; }
        public string[] Tips { get; set; }
    }
}
