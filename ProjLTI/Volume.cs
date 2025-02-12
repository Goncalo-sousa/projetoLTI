﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLTI
{
    public class AllVolumes
    {
        public List<Volume> volumes { get; set; }
    }
    public class Volume
    {
        public long Size { get; set; }
        public string Availability_zone { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Volume_type { get; set; }
        public string Status { get; set; }
        public bool Bootable  { get; set; }
    }
}
