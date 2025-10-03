// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T10 branch.
// Program to reverse input string.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         var input = ReadLine ();
         if (!String.IsNullOrEmpty (input)) WriteLine ("Output: " + ReverseString (input));
         else WriteLine ("Please enter a valid input!");
         Write ("Press 'Y' to continue");

      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static string ReverseString (string input) {
      List<char> chars = new ([.. input.ToLower ().Where (a => a != ' ').Reverse ()]);
      for (int i = 0; i < input.Length; i++) {
         if (char.IsWhiteSpace (input[i])) chars.Insert (i, input[i]);
         else if (char.IsUpper (input[i])) chars[i] = char.ToUpper (chars[i]);
         else chars[i] = char.ToLower (chars[i]);
      }
      return new string ([.. chars]);
   }
}