using System;
using System.Collections.Generic;
using System.Text;

namespace GShock.Core.ResponseTypes
{
    public class DurationTimeState
    {
        public string StateName { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public DurationTimeState(TimeSpan timeSpan, string stateName)
        {
            TimeSpan = timeSpan;
            StateName = stateName;
        }
    }
}
