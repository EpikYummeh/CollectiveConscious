using Bungie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungie.Responses
{
    public class GetBungieAccountResponse
    {
        public Clan[] Clans { get; set; }
        public HashMap<Group> RelatedGroups { get; set; }
        public BungieUser BungieNetUser { get; set; }
        public DestinyAccount[] DestinyAccounts { get; set; }
    }
}
