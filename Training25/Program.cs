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
      List<char> chars = [.. str.Where (a => !char.IsWhiteSpace (a))], reverse = [];
      for (int i = 0, j = 0, count = chars.Count - 1, len = str.Length; i < len; i++) {
         if (char.IsWhiteSpace (str[i])) reverse.Insert (i, str[i]);
         // Ascii values of 'A' and 'a' are 65 and 97 respectively i.e 'a' > 'A'
         else {
            reverse.Add (str[i] >= 'a' ? char.ToLower (chars[count - j]) :
               char.ToUpper (chars[count - j])); j++;
         }
      }
      return new string ([.. reverse]);
   }
}