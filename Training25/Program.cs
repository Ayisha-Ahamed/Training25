// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// T7: Program to print Pascal's triangle.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter number of rows[1-25]: ");
         if (int.TryParse (ReadLine (), out int rows) && rows > 0 && rows <= 25)
            PrintTriangle (GenerateTriangle (rows));
         else WriteLine ("Please enter an integer value within 1-25");
         Write ("\nPress 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns a jagged array of elements in Pascal's triangle with given number of rows.
   static int[][] GenerateTriangle (int rows) {
      int[][] triangle = new int[rows][];
      for (int i = 0; i < rows; i++) {
         triangle[i] = new int[1 + i];
         for (int k = 0, value = 1; k <= i; k++) {
            triangle[i][k] = value;
            // Using *= could truncate integer division to zero.
            value = value * (i - k) / (k + 1);
         }
      }
      return triangle;
   }

   // Prints formatted Pascal's triangle from jagged array.
   static void PrintTriangle (int[][] triangle) {
      int rows = triangle.Length,
         // Find the width of the largest number in the triangle.
         maxNumWidth = triangle[rows - 1][rows / 2].ToString ().Length + 1,
         // Find the width of the triangle.
         triangleWidth = rows * maxNumWidth;
      foreach (var row in triangle) {
         string line = "";
         foreach (var num in row) line += num.ToString ().PadLeft (maxNumWidth);
         WriteLine (line.PadLeft ((triangleWidth + line.Length) / 2));
      }
   }
}