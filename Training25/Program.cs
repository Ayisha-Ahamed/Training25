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
         Write ("Enter sequence of alphabetic characters: ");
         var input = ReadLine ();
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter))
            WriteLine ($"Reduced string: {Reduce (input)}");
         else WriteLine ("Please enter only alphabetic characters!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static string Reduce (string str) {
      int i = 0, len = str.Length - 1;
      string result = "";
      // Process input string up to second last character.
      while (i <= len) {
         // Increment index to exclude pairs of adjacent characters.
         if (i + 1 <= len && str[i] == str[i + 1]) i += 2;
         else result += str[i++];
      }
      return result;
   }
}