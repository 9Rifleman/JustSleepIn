﻿using StardewModdingAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSleepIn
{
    public class ModConfig
    {
        public KeybindList StaticTimeToggle { get; set; } = KeybindList.Parse("LeftControl + OemTilde");
    }
}
