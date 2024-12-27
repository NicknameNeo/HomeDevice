using System;

namespace HomeDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditioner cond = new Conditioner();
            Console.Write (cond.GetDeviceName);
            cond.Energy();
            cond.SetEnergyConsumption(100);
            cond.TurnOff();
            Console.WriteLine();
            
            Headter head = new Headter();
            Console.Write(head.GetDeviceName);
            head.Energy();
            head.SetEnergyConsumption(150);
            head.TurnOff();
        }
    }
}