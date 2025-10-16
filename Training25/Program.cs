// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T10: Program to reverse input string.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter string: ");
         var input = ReadLine ();
         if (!string.IsNullOrEmpty (input)) WriteLine ($"Reversed string: {Reverse (input)}");
         else WriteLine ("Please enter atleast one character!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns the reversed input string without altering spaces and capitalization.
   static string Reverse (string str) {
      List<char> chars = [.. str.Where (a => !char.IsWhiteSpace (a))], reverse = [];
      for (int i = 0, j = 0, count = chars.Count - 1, len = str.Length; i < len; i++) {
         switch (str[i]) {
            case ' ': reverse.Insert (i, str[i]); break;
            // Ascii values of 'A' and 'a' are 65 and 97 respectively i.e 'a' > 'A'
            case >= 'a': reverse.Add (char.ToLower (chars[count - j])); j++; break;
            default: reverse.Add (char.ToUpper (chars[count - j])); j++; break;
         }
      }
      return new string ([.. reverse]);
   }
}