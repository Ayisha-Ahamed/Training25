// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
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

   // Returns reduced string by removing pairs of adjacent letters.
   static string Reduce (string str) {
      string result = "";
      bool hasPairs = false;
      for (int i = 1, len = str.Length; i <= len; i++) {
         // Increment index if adjacent characters are equal.
         if (i < len && str[i] == str[i - 1]) {
            hasPairs = true;
            i++;
         } else result += str[i - 1];
      }
      // Reduce string until adjacent pairs of letters are no longer found.
      return !hasPairs ? result : Reduce (result);
   }
}