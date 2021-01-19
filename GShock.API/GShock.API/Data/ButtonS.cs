using GShock.BL;
using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GShock.API.Data
{
    public class ButtonS:IClickButton
    {
        public readonly IHandleState _handleState;

        public ButtonS(IHandleState handleState)
        {
            _handleState = handleState;
        }

        public Response Execute()
        {
            return _handleState.ButtonS();
        }

    }
}
