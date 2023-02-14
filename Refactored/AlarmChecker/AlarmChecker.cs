using KataCSharpStarting.Refactored.Alarm;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataCSharpStarting.Refactored.AlarmChecker
{
    internal class AlarmChecker
    {
        IAlarm alarm;

        public AlarmChecker(IAlarm alarm)
        {
            this.alarm = alarm;
        }

        public void DisplayAlarmState()
        {
            Console.WriteLine(alarm.GetState());
        }
    }
}
