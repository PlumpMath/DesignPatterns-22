﻿using Strategy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interfaces
{
    interface IStrategy
    {
        int Move(Context c);
    }
}
