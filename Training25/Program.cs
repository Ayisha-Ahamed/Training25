// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T9 branch.
// Program to reduce string by removing pairs of adjacent letters.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         var input = ReadLine ();
         if (!String.IsNullOrEmpty (input) && input.All (a => char.IsLetter (a)))
            WriteLine ("Output: " + ReducedString (input));
         else WriteLine ("Please enter a valid input!");
         Write ("Press 'Y' to continue");

      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static string ReducedString (string input) {
      int i = 0;
      string output = "";
      // Process input string up to second last character.
      while (i < input.Length - 1) {
         if (input[i] == input[i + 1]) i += 2;
         else output += input[i++];
      }
      if (i == input.Length - 1) output += input[i];
      return output;
   }
}