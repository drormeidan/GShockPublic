using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GShock.Core.States
{
    public interface IOperateState
    {
        public Response Refresh(int refreshTime);
        public Response ButtonB();
        public Response Refresh();
        public Response ButtonS();
        public Response ButtonA();
    }
}
