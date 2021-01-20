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
        public Response ButtonB();
        public Response ButtonS();
        public Response ButtonA();
        public Response ButtonC();
    }
}
