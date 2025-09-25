// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T3 branch.
// Program to find GCD and LCM of two numbers.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Clear ();
         WriteLine ("Enter two positive integers: ");
         if (int.TryParse (ReadLine (), out int num1) && int.TryParse (ReadLine (), out int num2)) {
            int gcd = GCD (num1, num2);
            WriteLine ($"GCD of {num1} and {num2} is {gcd}");
            WriteLine ($"LCM of {num1} and {num2} is {LCM (gcd, num1, num2)}");
         } else
            WriteLine ("Please enter positive integers!");
         WriteLine ("Press 'Y' to continue");
      }
      while (ReadKey (true).Key == ConsoleKey.Y);
   }

   /// <summary>Returns GCD of two positive integers.</summary>
   static int GCD (int num1, int num2) {
      int a = num1 + num2 - Math.Min (num1, num2), b = num1 + num2 - a;
      while (b != 0) {
         int r = a % b;
         a = b;
         b = r;
      }
      return a;
   }

   /// <summary>Returns the LCM of two positive integers.</summary>
   static int LCM (int gcd, int num1, int num2) => (num1 * num2) / gcd;
}