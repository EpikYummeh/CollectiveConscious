using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungie.Models
{
    public class CharacterClass
    {
        public long ClassHash { get; set; }
        public string ClassIdentifier { get; set; }
        public string ClassName { get; set; }
        public string ClassNameFemale { get; set; }
        public string ClassNameMale { get; set; }
        public int ClassType { get; set; }
        public long Hash { get; set; }
        public int Index { get; set; }
        public string MentorVendorIdentifier { get; set; }
        public bool Redacted { get; set; }
    }
}
