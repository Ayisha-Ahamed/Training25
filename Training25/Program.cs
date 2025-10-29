// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Test1: Program to sort even and odd digits in ascending order.
// Even digits are placed before odd digits.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         WriteLine ("Enter string of numbers[0-9]: ");
         var input = ReadLine () ?? "";
         if (!string.IsNullOrEmpty (input) && input.All (char.IsDigit))
            WriteLine (DigitSorter (input));
         else WriteLine ("Please enter string of numbers ranging from 0 to 9!");
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static string DigitSorter (string str) {
      var evens = str.Where (a => ((a - '0') & 1) == 0).Order ().ToArray ();
      var odds = str.Where (a => ((a - '0') & 1) != 0).Order ().ToArray ();
      return new string (evens) + new string (odds);
   }
}