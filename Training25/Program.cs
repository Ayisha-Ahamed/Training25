// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T3: Program to find GCD and LCM of two numbers.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         WriteLine ("Enter two positive integers: ");
         if (int.TryParse (ReadLine (), out int num1) && num1 > 0 &&
            int.TryParse (ReadLine (), out int num2) && num2 > 0) {
            int gcd = GCD (num1, num2);
            WriteLine ($"GCD of {num1} and {num2} is {gcd}");
            WriteLine ($"LCM of {num1} and {num2} is {LCM (gcd, num1, num2)}");
         } else WriteLine ("Please enter positive integers!");
         WriteLine ("Press 'Y' to continue");
      }
      while (ReadKey (true).Key == ConsoleKey.Y);
   }

   /// <summary>Returns GCD of two positive integers</summary>
   static int GCD (int num1, int num2) {
      while (num2 != 0) (num1, num2) = (num2, num1 % num2);
      return num1;
   }

   /// <summary>Returns LCM of two positive integers</summary>
   static int LCM (int gcd, int num1, int num2) => (num1 * num2) / gcd;
}