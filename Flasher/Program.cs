using System;
using System.Device.Gpio;

namespace Flasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Raspberry PI?");

            var gpio = new System.Device.Gpio.GpioController(PinNumberingScheme.Board);
        }
    }
}
