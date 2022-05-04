using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Inheritances
{
    public class FlashDisk : Storage
    {
        public FlashDisk(string model, int memoryMB)
        {
            MediaName = "Flash Disk";
            Model = model;
            Speed = (int)SpeedUSB.USB3;
            try
            {
                Memory = memoryMB;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\a\a\n\n\n\t\t{ex.Message}\n at {model}");
            }
        }

        public FlashDisk(string model, int memoryMB, string data)
        {
            MediaName = "Flash Disk";
            Model = model;
            Speed = (int)SpeedUSB.USB3;
            try
            {
                Memory = memoryMB;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\a\a\n\n\n\t\t{ex.Message}\n at {model}");
            }
            Data = data;

        }


        public override void PrintDeviceInfo()
        {
            base.PrintDeviceInfo();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("USB Technology: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (Speed == 480) Console.Write("USB2");
            else Console.Write("USB3");
            Console.WriteLine(".0");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Speed: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{(int)Speed} Mb");

            Console.ResetColor();
        }


    }
}
