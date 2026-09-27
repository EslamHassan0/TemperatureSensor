
namespace TemperatureSensor;

internal class Program
{
    static void Main(string[] args)
    {

        Sensor  sensor = new Sensor();
        Display display =  new Display();
        Alarm alarm = new Alarm(25);
        sensor.SensorChanged += display.ShowTemperature;
        sensor.SensorChanged += alarm.FireAlarm;
        while (true)
        {
            Console.WriteLine("Welcome The Temprature System .. ");
            Console.WriteLine("1. Set The Temprature Value");
            Console.WriteLine($"2. Set The Alarm Value (Default 25) (New Value {alarm.GetAlarmValue()})");
            Console.WriteLine("3. Exit");

            int.TryParse(Console.ReadLine(), out int result);
            switch (result)
            {
                case 1:
                    Console.Write("Please Enter  A Temprature Value in Degrees:  ");
                    int.TryParse(Console.ReadLine(),out int tempValue);
                    sensor.ChangeTempreature(tempValue);
                    break;
                case 2:
                    Console.Write("Please Enter  A Temprature Value for the Alarm:  ");
                    int.TryParse(Console.ReadLine(), out int alarmValue);
                    alarm.SetAlarmValue(alarmValue);
                    break;

                case 3:
                    return;
                default:
                    ErrorMassage("Worng Input, Please enter correct Value ");
                    break;
            }
        }
    }

    public static void ErrorMassage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
