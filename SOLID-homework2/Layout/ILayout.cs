using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework2.Layout
{
    public interface ILayout
    {
        public string GetLayout(string time, string message);
    }
}
