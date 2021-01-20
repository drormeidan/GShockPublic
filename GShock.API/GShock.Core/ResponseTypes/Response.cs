using System;
using System.Collections.Generic;
using System.Text;

namespace GShock.Core.ResponseTypes
{
    public class Response
    {
        public Response(string showString, bool nonUpdate = false)
        {
            Value = showString;
            NonUpdate = nonUpdate;
        }
        public Object Value { get; set; }
        public bool NonUpdate { get; set; }
    }
}
