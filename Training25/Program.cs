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
         var input = ReadLine ();
         if (int.TryParse (input, out int num)) {
            WriteLine ("BIN: " + ConvertToBinary (num));
            WriteLine ("HEX: " + ConvertToHex (num));
         } else
            WriteLine ("Please enter an integer value!");
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   /// <summary>Returns the string of bits converted from decimal to base number system</summary>
   public static string ConvertToBase (int numBase, int numVal) {
      StringBuilder numConBuilder = new ();
      int logTwo = (int)Math.Log2 (numBase);
      for (; numVal > 0; numVal >>= logTwo) {
         numConBuilder.Insert (0, ConvertToHexBit (numVal & (numBase - 1)));
      }
      return numConBuilder.ToString ();
   }

   /// <summary>Returns binary string from decimal input</summary>
   public static string ConvertToBinary (int num) => ConvertToBase (2, num);

   /// <summary>Returns hexadecimal string from decimal input</summary>
   public static string ConvertToHex (int num) => ConvertToBase (16, num);

   /// <summary>Returns character bit corresponsding to decimal number</summary>
   public static char ConvertToHexBit (int rem) =>
      (rem > 9) ? (char)(rem - 10 + 'A') : (char)(rem + '0');
}