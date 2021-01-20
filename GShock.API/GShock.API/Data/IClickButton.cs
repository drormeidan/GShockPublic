using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GShock.API.Data
{
    public interface IClickButton
    {
        public Response Execute(bool isDouble= false, bool isLong = false);
    }
}
