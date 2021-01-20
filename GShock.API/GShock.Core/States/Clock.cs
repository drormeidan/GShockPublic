using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GShock.Core.States
{
    public class Clock : IOperateState
    {
        public int HoursCorretion { get; set; }
        public int SecondsCorretion { get; set; }
        public int MinutesCorretion { get; set; }
        public bool InEditState { get; set; }
        private string _timeForamt = "hh:mm:ss";
        public string Name { get; set; }

        public Clock()
        {
            MinutesCorretion = 0;
            HoursCorretion = 0;
            SecondsCorretion = 0;
            InEditState = false;
            Name = "Clock";
        }
        private string DisplayTime()
        {
            var time = DateTime.Now;
            time = time + 
                new TimeSpan(HoursCorretion,MinutesCorretion,SecondsCorretion);
            return time.ToString(_timeForamt);
        }

        public Response ButtonA(bool isDouble, bool isLong)
        {
            InEditState = !InEditState;
            return new Response(DisplayTime());
        }

        public Response ButtonB(bool isDouble, bool isLong)
        {
            if (InEditState)
            {
                MinutesCorretion += 1;
            }
            return new Response(DisplayTime());
        }

        public Response ButtonC(bool isDouble, bool isLong)
        {
            if (InEditState)
            {
                if (isLong)
                {
                    var time = DateTime.Now +
                        new TimeSpan(HoursCorretion, MinutesCorretion, SecondsCorretion);
                    SecondsCorretion -= time.Second;
                }
                else
                {
                    HoursCorretion += 1;
                }
            }
            return new Response(DisplayTime());
        }

        public Response ButtonS()
        {
            return new Response(DisplayTime());
        }

        public Response Refresh()
        {
            return new Response(DisplayTime());
        }
    }

}

