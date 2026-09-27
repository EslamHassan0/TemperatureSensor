using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor;
public class Sensor //Subject
{
    public event EventHandler<TemperatureArgs> SensorChanged; // event when to value changes
    private int CurrentTemperature { get; set; }
    public void ChangeTempreature(int newTemperature)
    {
       CurrentTemperature = newTemperature;
       SensorChanged(this, new TemperatureArgs(CurrentTemperature));
    }
}
