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

   static string Reverse (string str) {
      List<char> chars = new ([.. str.Where (a => a != ' ').Reverse ()]);
      for (int i = 0, len = str.Length; i < len; i++) {
         if (char.IsWhiteSpace (str[i])) chars.Insert (i, str[i]);
         else if (char.IsUpper (str[i])) chars[i] = char.ToUpper (chars[i]);
         else chars[i] = char.ToLower (chars[i]);
      }
      return new string ([.. chars]);
   }
}