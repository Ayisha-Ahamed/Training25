// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// T11.1: Program that gets number n from command line and prints nth Armstrong number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      if (args.Length == 1 && int.TryParse (args[0], out int num) && num > 0 && num < 29)
         WriteLine (GetNthArmstrong (num));
      else WriteLine ("Please enter a valid input[1-28]");
   }

   // Returns nth armstrong number.
   static int GetNthArmstrong (int n) {
      int count = 0, num = 0;
      for (; count < n; num++) if (IsArmstrong (num)) count++;
      return num - 1;
   }

   // Returns if a number is an armstrong number.
   static bool IsArmstrong (int num) {
      string str = num.ToString ();
      return str.Select (a => (int)Math.Pow (a - '0', str.Length)).Sum () == num;
   }
}