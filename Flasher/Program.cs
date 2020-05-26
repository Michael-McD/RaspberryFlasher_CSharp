using System;
using System.Threading;
using System.Device.Gpio;

namespace Flasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Raspberry PI!");

            var gpio = new System.Device.Gpio.GpioController(PinNumberingScheme.Board);

            var pin = 11;
            var lightTime = 300;

            gpio.OpenPin(pin, PinMode.Output);
            try
            {
                var shouldRun = true;
                
                while (shouldRun)
                {
                    gpio.Write(pin, PinValue.High);
                    Thread.Sleep(lightTime);
                    gpio.Write(pin, PinValue.Low);
                    Thread.Sleep(lightTime);
                }
            }
            finally
            {
                gpio.ClosePin(pin);
            }

        }
    }
}
