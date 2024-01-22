using System;
class Program
{
    static void Main()
    {
        bool[] boolArray = { true, false, false, true, true, false, true, false };
        byte resultByte = ConvertBoolArrayToByte(boolArray);
        Console.WriteLine("Result: " + Convert.ToString(resultByte, 2).PadLeft(8, '0'));
    }
    static byte ConvertBoolArrayToByte(bool[] boolArray)
    {
        byte result = 0;
        for (int i = 0; i < 8; i++)
        {
            if (boolArray[i])
            {
                result |= (byte)(1 << (7 - i));
            }
        }
        return result;
    }
}









