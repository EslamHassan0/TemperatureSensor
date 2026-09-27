using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor;

public class Display
{
    public void ShowTemperature(object sender, TemperatureArgs args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($" -- The Temperature Value Is '{args.CurrentTemperature}' -- ");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine();
        Console.ResetColor();
    }
}
