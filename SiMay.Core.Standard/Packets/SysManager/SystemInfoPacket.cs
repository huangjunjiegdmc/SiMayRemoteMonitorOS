﻿using SiMay.ReflectCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiMay.Core
{
    public class ProcessListPack : EntitySerializerBase
    {
        public ProcessItem[] ProcessList { get; set; }
    }
    public class SystemInfoPacket : EntitySerializerBase
    {
        public SystemInfoItem[] SystemInfos { get; set; }
    }

    public class SystemOccupyPack : EntitySerializerBase
    {
        public string CpuUsage { get; set; }
        public string MemoryUsage { get; set; }
    }

    public class SystemInfoItem : EntitySerializerBase
    {
        public string ItemName { get; set; }
        public string Value { get; set; }
    }
}