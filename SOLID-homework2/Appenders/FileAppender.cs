using SOLID_homework2.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework2.Appenders
{
    public class FileAppender: IAppender
    {
        private readonly ILayout _layout;
        private readonly ILogFile _logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
        {
            _layout = layout;
            _logFile = logFile;
        }

        public void Write(string time, string message)
        {
           _logFile.AddData(_layout.GetLayout(time, message));
        }
    }
}
