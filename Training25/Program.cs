// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Test2: Program to generate excel column names [1 - 16384].
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Write ("Enter positive integer: ");
         if (int.TryParse (ReadLine (), out int num) && num > 0 && num <= 16384) WriteLine (Column (num));
         else WriteLine ("Enter positive integer within range [ 1 - 16384]");
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static string Column (int sNo) {
      int num = sNo - 1, quotient = num / 26, remainder = num % 26;
      string prefix = "";
      while (quotient > 0) {
         prefix += (char)('A' + quotient % 26 - 1);
         quotient /= 26;
      }
      return prefix + (char)('A' + remainder);
   }
}