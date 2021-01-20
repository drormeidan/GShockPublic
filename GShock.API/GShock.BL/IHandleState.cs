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
        public Response ButtonB();
        public Response ButtonC();
        public Response ButtonA();

    }
}
