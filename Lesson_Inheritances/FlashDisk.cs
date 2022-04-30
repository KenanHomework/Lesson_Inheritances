using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Inheritances
{
    public class FlashDisk : Storage
    {
        public FlashDisk(string mediaName, string model, int sizeOfMedia, SpeedUSB speedUSB, string data)
        {
            MediaName = mediaName;
            Model = model;
            Speed = (int)speedUSB;
            Memory = sizeOfMedia;
            SizeOfMedia = sizeOfMedia;

        }

        public int Speed { get; set; }



    }
}
