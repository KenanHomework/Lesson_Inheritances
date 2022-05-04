using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Inheritances
{
    public enum ConsoleSize { Height = 30, Width = 118 }

    public class Location
    {
        public Location(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; set; }
        public int Column { get; set; }

    }

    public abstract class Animations
    {
        static public void Turn(string loadingText, Location location, int loopCount)
        {
            Console.CursorVisible = false;
            for (int i = 0; i < loopCount; i++)
            {

                Console.SetCursorPosition(location.Column, location.Row);
                Console.Write(loadingText);

                switch (i % 4)
                {
                    case 0: Console.WriteLine("/"); break;
                    case 1: Console.WriteLine("-"); break;
                    case 2: Console.WriteLine("\\"); break;
                    case 3: Console.WriteLine("|"); break;
                }
                Thread.Sleep(75);
            }
        }

        static public void LoadingBar(string loadingTxt, Location location, int time)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(location.Column, location.Row);
            string loadingText = loadingTxt + " [";
            string loadingTextTerminator = "                 ]";
            Console.Write(loadingText + loadingTextTerminator);

            for (int i = 0; i < 16; i++)
            {
                if (i == 0)
                {
                    Console.SetCursorPosition(location.Column, location.Row);
                    Console.Write(loadingText + loadingTextTerminator);
                }

                Console.SetCursorPosition(location.Column + loadingText.Length + i, location.Row);
                Console.Write('*');

                Thread.Sleep(time / 18);
            }
        }


    }
}


