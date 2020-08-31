using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Homes
{
  public class TelemetryMessage
  {
    public string SensorName { get; internal set; }
    public int Value { get; internal set; }
  }
}
