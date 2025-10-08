// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T9: Program to reduce string by removing pairs of adjacent letters.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         var input = ReadLine ();
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter))
            WriteLine ("Output: " + Reduce (input));
         else WriteLine ("Please enter a valid input!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static string Reduce (string str) {
      int i = 0, len = str.Length;
      string output = "";
      // Process input string up to second last character.
      while (i < len - 1) {
         // Increment index to exclude pairs of adjacent characters.
         if (str[i] == str[i + 1]) i += 2;
         else output += str[i++];
      }
      // Include last character in output if updated index is within bounds of array.
      if (i == len - 1) output += str[i];
      return output;
   }
}