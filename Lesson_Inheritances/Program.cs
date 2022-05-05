using Lesson_Inheritances;

FlashDisk flash = new("Kingstone", 2000);
flash.PrintDeviceInfo();

flash.Copy(new DVD("MMMMEMORY", DVDType.OneSide,140, "                                     "));