using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Inheritances
{
    public abstract class UI
    {
        public static void LoadingAnimation(string homeType, string homeName, string targetType, string targetName, int duration)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n\n\t\tPreapering");
            Thread.Sleep(240);
            Console.Write(".");
            Thread.Sleep(240);
            Console.Write(".");
            Thread.Sleep(240);
            Console.Write(".");
        }

    }
}
