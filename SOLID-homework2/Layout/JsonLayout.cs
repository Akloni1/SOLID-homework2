using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_homework2.Layout
{
    public class JsonLayout : ILayout
    {
        public string GetLayout(string time, string message)
        {
            string json = JsonConvert.SerializeObject(new { time = time, message = message });
            return json;
        }
    }
}
