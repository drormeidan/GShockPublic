using System;
using System.Collections.Generic;
using System.Text;

namespace GShock.Core.ResponseTypes
{
    public class Response
    {
        public Response(string showString, bool nonUpdate = false)
        {
            ShowString = showString;
            NonUpdate = nonUpdate;
        }
        public string ShowString { get; set; }
        public bool NonUpdate { get; set; }
    }
}
