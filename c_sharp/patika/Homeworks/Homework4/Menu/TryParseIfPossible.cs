using System;

namespace patika.Homeworks.Homework4.Menu
{
    public static class TryParseIfPossible
    {
        public static byte FromStringToByte(string stringToConvert)
        {
            if (Byte.TryParse(stringToConvert, out byte byteValue))
                return byteValue;
            else
                return 0;
        }
    }
}