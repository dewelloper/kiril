﻿using Markum.Cloud.Libraries.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Libraries.Server
{
    public class ServerChangeMemoryModel : ServerBaseModel
    {
        [SolusVmQuery("memory")]
        public int MemorySize { get; set; }
    }
}
