// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Test3: Program prints if a 3 x 3 matrix is a magic square.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Clear ();
         WriteLine ("Enter 3 x 3 matrix: ");
         int[][] matrix = new int[3][];
         bool isValid = true;
         for (int i = 0; i < 3 && isValid; i++) {
            WriteLine ($"Enter row {i + 1}(space separated values): ");
            matrix[i] = new int[3];
            var input = ReadLine () ?? "";
            var numbers = input.Split (' ');
            for (int j = 0; j < 3; j++) {
               if (int.TryParse (numbers[j], out int num)) matrix[i][j] = num;
               else {
                  WriteLine ("Please enter valid integer input separated by space!");
                  isValid = false; break;
               }
            }
         }
         if (isValid) {
            PrintMatrix (matrix);
            WriteLine (IsMagicSquare (matrix) ? "Matrix is a magic square" : "Matrix is not a magic square");
         }
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
      WriteLine ("Hello, World!");
   }

   static void PrintMatrix (int[][] mat) {
      for (int i = 0; i < 3; i++) {
         Write ("[ ");
         for (int j = 0; j < 3; j++) {
            Write ($"{mat[i][j]} ");
         }
         Write ("]\n");
      }
   }

   static bool IsMagicSquare (int[][] mat) {
      int sum = mat[0].Sum (); // Sum of all elements in first row.
      // Check if the sum of individual columns and rows are equal to sum.
      for (int i = 0; i < 3; i++) {
         int cSum = 0, rSum = 0;
         for (int j = 0; j < 3; j++) {
            cSum += mat[j][i]; // Sum of ith column
            rSum += mat[i][j]; // Sum of ith row
         }
         if (cSum != sum || rSum != sum) return false;
      }
      // Check if sums of diagonal elements are equal to sum.
      int rDiag = 0, lDiag = 0; // Sum of diagonal elements from right to left and left to right respectively.
      for (int i = 0; i < 3; i++) {
         lDiag += mat[i][i];
         rDiag += mat[i][2 - i];
      }
      if (rDiag != sum || lDiag != sum) return false;
      return true;
   }
}