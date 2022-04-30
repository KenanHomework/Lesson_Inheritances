using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Inheritances
{
    public enum SpeedUSB { USB2 = 480, USB3 = 4640 }
    public abstract class Storage
    {
        public string MediaName { get; set; }

        public string Model { get; set; }

        public int Speed { get; set; }

        private int memory;

        public int Memory
        {
            get => memory;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Value must greater than zero!");
                memory = value;
            }
        }

        public string Data { get; set; } = "";



        public virtual void Copy(Storage otherDevice) { }

        public int FreeMemory() => Memory - Data.Length;

        public virtual void PrintDeviceInfo()
        {
            Console.ResetColor();

            Console.Write("Media Name: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(MediaName);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Model: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Model);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Data Size: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Data.Length} MB");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Memory: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Memory} MB");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Free Memory: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{FreeMemory()}");

            Console.ResetColor();
        }


    }
}
