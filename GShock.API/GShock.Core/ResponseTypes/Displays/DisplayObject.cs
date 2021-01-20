using System;
using System.Collections.Generic;
using System.Text;

namespace GShock.Core.ResponseTypes.Displays
{
    public class DisplayObject
    {
        public DisplayObject(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
