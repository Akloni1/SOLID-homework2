﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework2.Appenders
{
    public interface IAppender
    {   
        public void Write(string time, string message);
    }
}
