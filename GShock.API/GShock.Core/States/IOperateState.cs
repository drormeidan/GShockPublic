using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GShock.Core.States
{
    public interface IOperateState
    {
        public Response Refresh();
        public Response ButtonB(bool isDouble, bool isLong);
        public Response ButtonS();
        public Response ButtonA(bool isDouble, bool isLong);
        public Response ButtonC(bool isDouble, bool isLong);
    }
}
