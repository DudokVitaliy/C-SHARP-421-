namespace _11_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Device device = new Device(); 
            TV tv = new TV("LG");
            Smartphone smartphone = new Smartphone("Nokia");
            tv.Print();
            smartphone.Print();
            Console.WriteLine($"{new string('=', 50)}");
            Device[] devices = new Device[] { tv, smartphone, new SmartTV()}; 
            foreach (Device device in devices)
            {
                device.Print();
                // ((TV)device).NextChannel(); - error
                //TV temp_TV = device as TV;
                //if (temp_TV != null)
                //    temp_TV.NextChannel();
                //Smartphone temp_Smartphone = device as Smartphone;
                //if (temp_Smartphone != null)
                //    temp_Smartphone.Call();
                if (device is TV)
                    (device as TV).NextChannel();
                if (device is Smartphone)
                    (device as Smartphone).Call();

            }
        }
    }
}
