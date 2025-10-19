// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program returns the smallest number of steps to transform a number into identical digits.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter number: ");
         if (int.TryParse (ReadLine (), out int num)) {
            (int digit, int steps) = NTransform (num);
            WriteLine ($"{num} -> {new string ((char)(digit + '0'), num.ToString ().Length)} "
              + $"{steps} steps");
         } else WriteLine ("Please enter integer input!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns the number of transforms required to change a number into identical digits.
   static (int digit, int steps) NTransform (int num) {
      var dArr = num.ToString ().Select (a => a - '0').ToArray (); // Array of digits in num.
      int nSteps = 1000, digit = 0; // Assuming the transform takes 1000 steps initially.
      for (int i = 0, len = dArr.Length; i < len; i++) {
         int temp = 0;
         for (int j = 0; j < len; j++) temp += (Math.Abs ((dArr[i] - dArr[j])));
         if (temp < nSteps) (nSteps, digit) = (temp, dArr[i]);
      }
      return (digit, nSteps);
   }
}