// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T6 branch.
// Program to find the digital root of a number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0)
            WriteLine ($"Digital root of {num} is {DigitalRoot (num)}");
         else WriteLine ("Please enter a positive integer!");
         Write ("Press 'Y' to continue");
      } while (ReadKey ().Key == ConsoleKey.Y);
   }

   /// <summary>Returns the digital root of the input.</summary>
   static int DigitalRoot (int num) {
      int sum = num;
      while (sum > 9) sum = sum.ToString ().ToCharArray ().Sum (x => x - '0');
      return sum;
   }
}