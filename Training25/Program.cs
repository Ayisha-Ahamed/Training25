// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T11: Program to find if a number is an armstrong number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0)
            WriteLine ($"{num} is {(IsArmstrong (num) ? "" : "not ")}an armstrong number");
         else WriteLine ("Please enter a positive integer!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns if the input number is an armstrong number.
   static bool IsArmstrong (int num) {
      int sum = 0, quotient = num, pow = num.ToString ().Length;
      while (quotient > 0) {
         sum += (int)Math.Pow (quotient % 10, pow);
         quotient /= 10;
      }
      return sum == num;
   }
}