// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// T14: Program prints the smallest number of steps to transform a number into identical digits.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter number: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0) {
            (int digit, int steps) = NTransform (num);
            WriteLine ($"{num} -> {new string ((char)(digit + '0'), num.ToString ().Length)}"
              + $" {steps} steps");
         } else WriteLine ("Please enter a valid positive integer!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns the number of transforms required to change a number into identical digits.
   static (int Digit, int Steps) NTransform (int num) {
      // Extract array of digits from num.
      var dArr = num.ToString ().Select (a => a - '0').ToArray ();
      // Assume the transform takes 1000 steps initially.
      (int digit, int steps) = (0, 1000);
      for (int i = 0, len = dArr.Length; i < len; i++) {
         int temp = 0;
         for (int j = 0; j < len; j++) temp += Math.Abs (dArr[i] - dArr[j]);
         if (temp < steps) (steps, digit) = (temp, dArr[i]);
      }
      return (digit, steps);
   }
}