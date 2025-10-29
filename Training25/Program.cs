// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// T10: Program to reverse input string.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter string: ");
         var input = ReadLine () ?? "";
         if (input.Length > 1) WriteLine ($"Reversed string: {Reverse (input)}");
         else WriteLine ("Please enter string of characters!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns the reversed input string without altering spaces and capitalization.
   static string Reverse (string str) {
      // Remove space characters from string.
      char[] letters = [.. str.Where (a => !char.IsWhiteSpace (a))], reverse = new char[str.Length];
      int nLetters = letters.Length; // Numbers of letters in the string.
      for (int i = 0; i < str.Length && nLetters > 0; i++) {
         if (char.IsWhiteSpace (str[i])) reverse[i] = str[i];
         else {
            char ch = letters[--nLetters];
            reverse[i] = (char.IsLower (str[i]) ? char.ToLower (ch) : char.ToUpper (ch));
         }
      }
      return new string (reverse);
   }
}