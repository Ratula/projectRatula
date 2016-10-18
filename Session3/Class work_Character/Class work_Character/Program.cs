// File: Char.cs
using System;

class TestChar
{
    static void Main()
    {
        // Assign a single character 'a' to chSomeChar
        char someChar = 'a'; //2 bytes

        // Convert an integer value (65) into a character
        someChar = (char)65; //integer is 4 bytes. so to convert integer to character you need to squeeze

        // Convert a character value into an integer (8 bytes)
        long someLong = someChar; //what it is assigned to or converting to is on the left side 

        // Convert a character value into an integer (4 bytes)
        int someInt = someChar;

        // Convert a character value into a short (2 bytes)
        short someShort = (short)someChar;

        // Convert a character value into a byte (1 byte)
        byte someByte = (byte)someChar;
    }
}
