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
               WriteLine ("Password is strong");
            else WriteLine ("""
               Invalid password!
               Password must have atleast 6 characters
               Password must not include space characters
               Password must have atleast one lower case character
               Password must have atleast one upper case character
               Password must have atleast one numeric character
               Password must have atleast one special character
               """);
         } else WriteLine ("Please enter a non-empty string!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }
}