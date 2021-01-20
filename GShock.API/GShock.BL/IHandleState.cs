using GShock.Core;
using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GShock.BL
{
    public interface IHandleState
    {
        public Response Refresh();
        public Response ButtonS();
        public Response ButtonB(bool isDouble = false, bool isLong = false);
        public Response ButtonC(bool isDouble = false, bool isLong = false);
        public Response ButtonA(bool isDouble = false, bool isLong = false);

    }
}
