﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Controls
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}