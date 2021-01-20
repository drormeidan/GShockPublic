using GShock.Core.ResponseTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GShock.Core.States
{
    public class Dater : IOperateState
    {
        public int MonthsCorretion { get; set; }
        public double DaysCorretion { get; set; }
        public bool InEditState { get; set; }
        private string _dateForamt = "dd/MM/yyyy";
        public string Name { get; set; }

        public Dater()
        {
            DaysCorretion = 0;
            MonthsCorretion = 0;
            InEditState = false;
            Name = "Dater";
        }

        private string DisplayTime()
        {
            var time = DateTime.Now;
            time = time.AddDays(DaysCorretion).AddMonths(MonthsCorretion);
            return time.ToString(_dateForamt);
        }

        public Response ButtonA()
        {
            InEditState = !InEditState;
            return new Response(DisplayTime());
        }

        public Response ButtonB()
        {
            if (InEditState)
            {
                DaysCorretion += 1;
            }
            return new Response(DisplayTime());
        }

        public Response ButtonC()
        {
            if (InEditState)
            {
                MonthsCorretion += 1;
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
