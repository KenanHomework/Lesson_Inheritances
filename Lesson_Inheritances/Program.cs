using Lesson_Inheritances;

FlashDisk flash = new("Kingstone", 2000, SpeedUSB.USB2);
flash.PrintDeviceInfo();

flash.Copy(new DVD());