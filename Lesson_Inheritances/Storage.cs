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



        public void Copy(Storage otherDevice)
        {
            Console.Clear();
            Animations.Turn("Preaparing...", new Location(15, 59 - 13), 30);
            Thread.Sleep(75);
            Console.Clear();
            Animations.Turn($"{otherDevice.MediaName}...",
                new Location(15, 59 - (otherDevice.MediaName.Length + 3)), 15);
            Thread.Sleep(75);
            Console.Clear();
            Animations.Turn($"{otherDevice.Model} ~ Preaparing...",
                new Location(15, 59 - (otherDevice.Model.Length + 16)), 15);
            Thread.Sleep(75);
            Console.Clear();
            if (otherDevice.Data.Length > FreeMemory())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Data is biggest than free memory !");
                Console.ResetColor();
                return;
            }
            Animations.Turn($"Data Transfer Starting...", new Location(15, 59 - 23), 20);
            this.Data = otherDevice.Data;
            Thread.Sleep(75);
            Console.Clear();
            Animations.LoadingBar("Copying...", new Location(15, 59 - 7), otherDevice.Data.Length / this.Speed);
            this.Data = otherDevice.Data;
            Thread.Sleep(75);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(50, 13);
            Console.Write("Succes !");
            Thread.Sleep(1451);
            Console.Clear();
            Console.ResetColor();
        }

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
