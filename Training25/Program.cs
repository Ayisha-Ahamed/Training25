// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T1 branch.
// Program to convert decimal input to binary and hexadecimal.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Clear ();
         Write ("Input: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0) {
            WriteLine ("BIN: " + ConvertToBase (2, num));
            WriteLine ("HEX: " + ConvertToBase (16, num));
         } else
            WriteLine ("Please enter a positive integer!");
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   /// <summary>Returns the string of bits converted from decimal to base number system</summary>
   public static string ConvertToBase (int numBase, int numVal) {
      StringBuilder numConBuilder = new ();
      int logTwo = (int)Math.Log2 (numBase);
      for (; numVal > 0; numVal >>= logTwo)
         numConBuilder.Append (ConvertToHexBit (numVal & (numBase - 1)));
      return numConBuilder.Length == 0 ? "0" : new string (numConBuilder.ToString ().Reverse ().ToArray ());
   }

   /// <summary>Returns character bit corresponsding to decimal number</summary>
   public static char ConvertToHexBit (int rem) =>
      (rem > 9) ? (char)(rem - 10 + 'A') : (char)(rem + '0');
}