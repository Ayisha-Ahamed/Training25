// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// T11: Program to print if the input number is an armstrong number.
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
      string str = num.ToString ();
      return str.Select (a => (int)Math.Pow (a - '0', str.Length)).Sum () == num;
   }
}