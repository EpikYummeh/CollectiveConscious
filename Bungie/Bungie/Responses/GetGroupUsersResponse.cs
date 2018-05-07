using Bungie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungie.Responses
{
    public class GetGroupUsersResponse
    {
        public GroupResults[] results { get; set; }
        public bool hasMore { get; set; }

    }
}
