﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Inheritances
{
    public class FlashDisk : Storage
    {
        public FlashDisk(string model, int memoryMB, SpeedUSB speedUSB)
        {
            MediaName = "Flash Disk";
            Model = model;
            Speed = (int)speedUSB;
            try
            {
                Memory = memoryMB;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\a\a\n\n\n\t\t{ex.Message}\n at {model}");
            }
            Speed = (int)speedUSB;
        }

        public FlashDisk(string model, int memoryMB, SpeedUSB speedUSB, string data)
        {
            MediaName = "Flash Disk";
            Model = model;
            Speed = (int)speedUSB;
            try
            {
                Memory = memoryMB;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\a\a\n\n\n\t\t{ex.Message}\n at {model}");
            }
            Speed = (int)speedUSB;
            Data = data;

        }

        public override void PrintDeviceInfo()
        {
            base.PrintDeviceInfo();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("USB Technology: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{Speed.ToString()}.0");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Speed: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{(int)Speed} Mb");

            Console.ResetColor();
        }

        public override void Copy(Storage otherDevice)
        {

            Animations animations = new();

            //animations.Turn("Preaparing...", new Location(23, 59 - 13), 40);

            while (true)
            {
                animations.LoadingBar("Preaparing....", new Location(23, 59 - 13));
            }

        }


    }
}
