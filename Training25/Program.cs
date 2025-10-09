// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T7: Program to print Pascal's triangle.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter number of rows[1-25]: ");
         if (int.TryParse (ReadLine (), out int rows) && rows <= 25) PrintTriangle (rows);
         else WriteLine ("Please enter an integer value within 1-25");
         Write ("\nPress 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static void PrintTriangle (int rows) {
      for (int i = 0; i < rows; i++) {
         Write (new string (' ', rows - i - 1));
         for (int k = 0, value = 1; k <= i; k++) {
            Write ($"{value} ");
            // Using *= could truncate integer division to zero.
            value = value * (i - k) / (k + 1);
         }
         WriteLine ();
      }
   }
}