using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework2
{
    public class LogFile: ILogFile
    {
        private List<string> _data;
        public LogFile()
        {
            _data = new List<string>();
        }
        public void AddData(string log)
        {
            _data.Add(log);
        }
    }
}
