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
   static void Main (string[] args) {
      do {
         Clear ();
         Write ("Enter input: ");
         if (int.TryParse (ReadLine (), out int num))
            WriteLine ($"Digital root of {num} is {DigitalRoot (num)}");
         else WriteLine ("Please enter an integer!");
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey ().Key == ConsoleKey.Y);
   }

   /// <summary>Returns the digital root of the input.</summary>
   static int DigitalRoot (int num) {
      int sum = 0;
      num.ToString ().ToCharArray ().Sum (x => sum += (x - '0'));
      while (sum > 9) {
         int temp = 0;
         sum.ToString ().ToCharArray ().Sum (x => temp += (x - '0'));
         sum = temp;
      }
      return sum;
   }
}