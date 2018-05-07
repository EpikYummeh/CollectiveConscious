﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bungie.Models
{
    public class Group
    {
        public long GroupId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string BannerPath { get; set; }
        public string AvatarPath { get; set; }
        public string ClanCallSign { get; set; }
        public DateTime CreationDate { get; set; }
    }
}