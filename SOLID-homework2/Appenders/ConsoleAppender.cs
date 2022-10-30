using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_homework2.Layout;

namespace SOLID_homework2.Appenders
{
    public class ConsoleAppender: IAppender
    {


        private readonly ILayout _layout;
        public ConsoleAppender(ILayout layout)
        {
            _layout = layout;
        }

        public void Write(string time, string message)
        {
            Console.WriteLine(_layout.GetLayout(time, message));
        } 
       
    }
}
