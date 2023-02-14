using System;
using System.Collections.Generic;
using System.Text;

namespace KataCSharpStarting.Refactored.Alarm
{
    public interface IAlarm
    {
        public bool IsAlarmOn { get; set; }
        string GetState();
    }
}
