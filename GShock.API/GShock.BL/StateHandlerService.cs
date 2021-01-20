using GShock.Core;
using GShock.Core.ResponseTypes;
using GShock.Core.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GShock.BL
{
    public class StateHandlerService : IHandleState
    {
        public IOperateState[] States;
 
        public int CurrentStateId;
        private DateTime _startTimeState;
        private DateTime _endTimeState;

        public StateHandlerService()
        {
            States = new IOperateState[] { new Timer(), new Dater(), new Clock() };
            CurrentStateId = 0;
            _startTimeState = DateTime.Now;
            _endTimeState = DateTime.Now;
        }

        public Response ButtonA(bool isDouble = false, bool isLong = false)
        {
            return States[CurrentStateId].ButtonA(isDouble, isLong);
        }

        public Response ButtonB(bool isDouble = false, bool isLong = false)
        {
            return States[CurrentStateId].ButtonB(isDouble, isLong);
        }

        public Response ButtonC(bool isDouble = false, bool isLong = false)
        {
            return States[CurrentStateId].ButtonC(isDouble, isLong);
        }

        public Response ButtonS()
        {
            var response = States[CurrentStateId].ButtonS();
            // _endTimeState = DateTime.Now;
            // DurationTimeState durationTimeState = new DurationTimeState()
            CurrentStateId = (CurrentStateId + 1) % States.Length;
            return States[CurrentStateId].Refresh();
        }

        public Response Refresh()
        {
            return States[CurrentStateId].Refresh();
        }
    }
}
