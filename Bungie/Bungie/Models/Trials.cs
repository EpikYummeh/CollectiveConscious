namespace Bungie.Models
{
    using Newtonsoft.Json;
    using System;

    public class Trials
    {
        public long[] BountyHashes { get; set; }
        public TrialsDisplay Display { get; set; }

    }
}