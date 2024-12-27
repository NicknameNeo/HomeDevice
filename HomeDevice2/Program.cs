using System;

namespace HomeDevice
{
    class H_Device
    {
        private string DeviceName;
        protected int EnergyConsumption;
        private bool IsOn;

        public string GetDeviceName
        {
            get {return DeviceName;}
            set { DeviceName = value; }
        }

        public int GetEnergyConsumption
        {
            get {return EnergyConsumption;}
            set { EnergyConsumption = value; }
        }

        public void Energy()
        {
            Console.WriteLine($"{EnergyConsumption} watts per second");
        }
        
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{DeviceName} is turned off");
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{DeviceName} is turned on");
        }
        public void SetEnergyConsumption(int value)
        {
            EnergyConsumption += value;
            Console.WriteLine($"Energy consumption for {DeviceName} set to {EnergyConsumption} watts.");
        }
        
    }
    
}