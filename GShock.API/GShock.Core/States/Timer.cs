using GShock.Core.ResponseTypes;
using System;

namespace GShock.Core.States
{
    public class Timer : IOperateState
    {
        public Timer()
        {
            _isRunning = true;
            _endTime = DateTime.Now.AddSeconds(15);
            _timeLeft = _endTime-DateTime.Now;
            Name = "Timer";
            _timeLeftFormat = @"hh\:mm\:ss\.fff";
        }
        private bool _isRunning;
        private TimeSpan _timeLeft;
        private DateTime _endTime;
        private string _timeLeftFormat;
        public string Name { get; set; }
        public Response Refresh()
        {
            if (_isRunning)
            {
                if (_endTime > DateTime.Now)
                {
                    _timeLeft = _endTime - DateTime.Now;

                }
                else
                {
                    _timeLeft = new TimeSpan();
                }
            }
            return new Response(_timeLeft.ToString(_timeLeftFormat));
        }

        public Response ButtonB()
        {
            _endTime = _endTime.AddMinutes(1);
            _timeLeft = _timeLeft.Add(new TimeSpan(0, 1, 0));
            return this.Refresh();
        }
        public Response ButtonS()
        {
            return this.Refresh();
        }

        public Response ButtonA()
        {
            _isRunning = !_isRunning;
            if (_isRunning)
            {
                _endTime = DateTime.Now + _timeLeft;
            }
            return this.Refresh();
        }

        public Response ButtonC()
        {
            _endTime = _endTime.AddHours(1);
            _timeLeft = _timeLeft.Add(new TimeSpan(1, 0, 0));
            return this.Refresh();
        }
    }
}