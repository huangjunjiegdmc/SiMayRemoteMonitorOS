﻿using SiMay.ReflectCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiMay.Core
{
    public class DoCreateRegistryKeyPacket : EntitySerializerBase
    {
        public string ParentPath { get; set; }
    }
}