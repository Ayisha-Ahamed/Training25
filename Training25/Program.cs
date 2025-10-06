// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T11 branch.
// Program to find if a number is an armstrong number.
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
      } while (ReadKey ().Key == ConsoleKey.Y);
   }

   static bool IsArmstrong (int input) {
      double sum = 0, num = input, pow = input.ToString ().Length;
      while (input > 0) {
         sum += Math.Pow (input % 10, pow);
         input /= 10;
      }
      return sum == num;
   }
}