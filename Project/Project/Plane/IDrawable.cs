﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plane
{
    public interface IDrawable
    {
        char[,] Image { get; set; }
    }
}