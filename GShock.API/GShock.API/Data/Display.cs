using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GShock.API.Data
{
    public class Display
    {
        public string Type { get; set; }

        public Display(string type, object value)
        {
            Type = type;
            Value = value;
        }

        public Object Value { get; set; }
    }
}
