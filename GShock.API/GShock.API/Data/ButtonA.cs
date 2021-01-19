﻿using GShock.BL;
using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GShock.API.Data
{
    public class ButtonA : IClickButton
    {
        public readonly IHandleState _handleState;

        public ButtonA(IHandleState handleState)
        {
            _handleState = handleState;
        }

        public Response Execute()
        {
            return _handleState.ButtonA();
        }
    }
}
