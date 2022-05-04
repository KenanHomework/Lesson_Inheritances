using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Inheritances
{
    public enum DVDType { OneSide = 4700, TwoSide = 9000 }
    public class DVD : Storage
    {
        public DVD(string model, DVDType type, int speed)
        {
            MediaName = "DVD";
            Model = model;
            Speed = speed > 0 ? speed : 480;
            Memory = (int)type;
        }

        public DVD(string model, DVDType type, int speed, string data)
        {
            MediaName = "DVD";
            Model = model;
            Speed = speed > 0 ? speed : 480;
            Memory = (int)type;
            Data = data;
        }



        public override void PrintDeviceInfo()
        {
            base.PrintDeviceInfo();
        }
    }
}
