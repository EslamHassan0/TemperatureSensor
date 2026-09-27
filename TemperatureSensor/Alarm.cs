using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor;

public class Alarm
{
    public Alarm(int alarmValue)
    {
        AlarmValue = alarmValue;
    }

    //Threshold 
    private int AlarmValue { get; set; }

    public int GetAlarmValue()
        => AlarmValue;
    public void SetAlarmValue(int value)
    {
        AlarmValue = value;
    }

    public void FireAlarm(object sender , TemperatureArgs args)
    {
        if(args.CurrentTemperature > AlarmValue)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($" -- Take Care, The Temperature Value {args.CurrentTemperature} is Greater Then {AlarmValue} -- ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
        }
    }
}
