using System;
using System.Collections.Generic;
using System.Text;
using KataCSharpStarting.Refactored.Sensor;

namespace KataCSharpStarting.Refactored.Alarm
{
    public class BasicAlarm : IAlarm
    {
        private const double LowPresureThreashold = 17;
        private const double HighPresureThreshold = 21;
        private readonly ISensor sensor;

        public bool IsAlarmOn { get; set; }
        public BasicAlarm(ISensor sensor)
        {
            this.sensor = sensor;
            IsAlarmOn = false;
        }

        private void CheckPressure()
        {
            var psiPressureValue = sensor.SamplePressure();
            if (psiPressureValue < LowPresureThreashold || psiPressureValue > HighPresureThreshold)
                IsAlarmOn = true;
            else
                IsAlarmOn = false;
        }

        public string GetState()
        {
            CheckPressure();
            if (IsAlarmOn)
                return "BEEP BOOP the alarm bells are ringing! Control the pressure";
            return "Everything is fine";
        }
    }
}
