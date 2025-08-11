using System;
using OldPhonePad;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(OldPhonePadFunctions.OldPhonePad("33#"));
        Console.WriteLine(OldPhonePadFunctions.OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePadFunctions.OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePadFunctions.OldPhonePad("8 88777444666*664#"));
        Console.WriteLine(OldPhonePadFunctions.OldPhonePad("this part should be ignored 8 88777444666*664#"));
        Console.WriteLine(OldPhonePadFunctions.OldPhonePad("8 88777444666*664")); // No # at the end, should return empty string
        Console.WriteLine(OldPhonePadFunctions.OldPhonePad("8 88 888 8888 88888 888888#123"));
    }
}