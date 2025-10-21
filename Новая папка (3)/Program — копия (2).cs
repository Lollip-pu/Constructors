using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{


    class Device
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
        }

        public Device(string brand)
        {
            this.brand = brand;
        }

        public void PowerOn()
        {
            Console.WriteLine($"{brand} включён.");
        }
    }

    class Laptop : Device
    {
        private int ram;
        private int battery;

        public int Ram
        {
            get { return ram; }
        }

        public int Battery
        {
            get { return battery; }
        }

        public Laptop(string brand, int ram, int battery) : base(brand)
        {
            this.ram = ram;
            this.battery = battery;
        }

        public void Work()
        {
            if (ram < 1 || ram > 64)
            {
                Console.WriteLine("ОЗУ должно быть от 1 до 64.");
            }
            else
            {
                Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {ram} ГБ, заряд: {battery}%.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Laptop laptop = new Laptop("Dell", 16, 85);
            laptop.PowerOn();
            laptop.Work();

            Laptop laptop2 = new Laptop("HP", 0, 55);
            laptop2.PowerOn();
            laptop2.Work();
        }
    }
}

