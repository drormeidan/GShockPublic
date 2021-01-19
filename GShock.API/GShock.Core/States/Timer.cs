using GShock.Core.ResponseTypes;
using System;

namespace GShock.Core.States
{
    public class Timer : IOperateState
    {
        public Timer()
        {
            _isRunning = true;
            _timeLeft = new TimeSpan(0, 0, 15);
            Name = "Timer";
        }
        private bool _isRunning;
        private TimeSpan _timeLeft;
        public string Name { get; set; }
        public Response Refresh(int refreshTime)
        {
            if (_timeLeft > new TimeSpan() && _isRunning)
            {
                _timeLeft = _timeLeft.Subtract(new TimeSpan(0, 0, refreshTime));
            }
            return new Response(_timeLeft.ToString());
        }

        public Response ButtonB()
        {
            _timeLeft = _timeLeft.Add(new TimeSpan(0, 1, 0));
            return new Response(_timeLeft.ToString());
        }
        public Response ButtonS()
        {
            return new Response(_timeLeft.ToString());
        }

        public Response ButtonA()
        {
            _isRunning = !_isRunning;
            return new Response(_timeLeft.ToString());
        }

        public Response ButtonC()
        {
            _timeLeft = _timeLeft.Add(new TimeSpan(1, 0, 0));
            return new Response(_timeLeft.ToString());
        }
    }
}