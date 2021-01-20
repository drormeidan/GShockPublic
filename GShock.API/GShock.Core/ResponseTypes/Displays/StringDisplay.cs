using System;
using System.Collections.Generic;
using System.Text;

namespace GShock.Core.ResponseTypes.Displays
{
    public class StringDisplay : DisplayObject
    {
        public string Value { get; set; }
        public StringDisplay(string value): base("string")
        {
            Value = value;
        }
    }
}
