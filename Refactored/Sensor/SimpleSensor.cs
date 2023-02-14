using System;
using System.Collections.Generic;
using System.Text;

namespace KataCSharpStarting.Refactored.Sensor
{
    internal class SimpleSensor : ISensor
    {
        private const int OFFSET = 16;
        Random basicRandomNumbersGenerator;

        public SimpleSensor()
        {
            basicRandomNumbersGenerator = new Random();
        }

        public double SamplePressure()
        {
            double pressureTelemetryValue = 6 * basicRandomNumbersGenerator.NextDouble() * basicRandomNumbersGenerator.NextDouble();
            return pressureTelemetryValue + OFFSET;
        }
    }
}
