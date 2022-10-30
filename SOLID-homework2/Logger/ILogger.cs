using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework2.Logger
{
    public interface ILogger
    {
        public void Error(string time, string message);
        public void Info(string time, string message);

    }
}
