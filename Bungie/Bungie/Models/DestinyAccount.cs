using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungie.Models
{
    public class DestinyAccount
    {
        public UserInfo userInfo { get; set; }
        public Character[] Characters { get; set; }
    }
}
