﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IMission
    {
        public string CodeName { get; set; }
        public State State { get; set; }
        
    }
}
