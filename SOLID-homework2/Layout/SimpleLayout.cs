﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework2.Layout
{
    public class SimpleLayout : ILayout
    {
        public string GetLayout(string time, string message)
        {
            return time+message;
        }
    }
}
