// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T11.1 branch.
// Program to find nth Armstrong number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      if (args.Length == 1 && int.TryParse (args[0], out int num) && num > 0 && num < 30)
         WriteLine (Armstrong (num));
      else WriteLine ("Please enter a valid input[1-29]");
   }

   static int Armstrong (int input) {
      int count = 0, num = 0;
      for (; count < input; num++) if (IsArmstrong (num)) count++;
      return num - 1;
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