using KataCSharpStarting.Refactored.Alarm;
using KataCSharpStarting.Refactored.AlarmChecker;
using KataCSharpStarting.Refactored.Sensor;
using System;

namespace KataCSharpStarting
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new SimpleSensor();
            var alarm = new BasicAlarm(sensor);
            var alarmChecker = new AlarmChecker(alarm);
            for(int i = 0; i < 20; i++)
            {
                alarmChecker.DisplayAlarmState();
            }
        }
    }
}
