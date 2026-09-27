using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor;

public class TemperatureArgs : EventArgs
{
    public int CurrentTemperature { get; set; }

    public TemperatureArgs(int currentTemperature)
    {
        CurrentTemperature = currentTemperature;
    }
}
