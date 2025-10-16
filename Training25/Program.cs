// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T8: Program to check if a pasword is strong.
// ------------------------------------------------------------------------------------------------
using System.Text.RegularExpressions;
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter password: ");
         var input = ReadLine ();
         if (!string.IsNullOrEmpty (input)) {
            if (input.Length >= 6 && !input.Any (char.IsWhiteSpace) && input.Any (char.IsLower)
               && input.Any (char.IsUpper) && input.Any (char.IsNumber) &&
               Regex.IsMatch (input, @"(?=.*[!@#$%^&*()-+])"))
               WriteLine ("Password is strong.");
            else WriteLine ("""
               Password is invalid. Please ensure it includes:
               - Atleast 6 characters
               - No spaces
               - Atleast one lower case character (a-z)
               - Atleast one upper case character (A-Z)
               - Atleast one number (0-9)
               - Atleast one special character (!@#$%^&*()-+)
               """);
         } else WriteLine ("Password cannot be empty.");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }
}