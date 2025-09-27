// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T8 branch.
// Program to check if a pasword is strong.
// ------------------------------------------------------------------------------------------------
using System.Text.RegularExpressions;
using static System.Console;
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Clear ();
         Write ("Enter password: ");
         var input = ReadLine ();
         if (!String.IsNullOrEmpty (input)) {
            var regex = new Regex ("^(?!.*\\s)(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()-+]).+$"
               + "^.{8,}$");
            if (regex.IsMatch (input))
               WriteLine ("Password is valid");
            else {
               if (input.Length < 8) WriteLine ("Password must have atleast 8 characters.");
               if (!input.ToCharArray ().Any (x => (x >= 'a' && x <= 'z')))
                  WriteLine ("Password must have atleast one upper case character.");
               if (!input.ToCharArray ().Any (x => (x >= 'A' && x <= 'Z')))
                  WriteLine ("Password must have atleast one lower case character.");
               if (!input.ToCharArray ().Any (x => (x >= '0' && x <= '9')))
                  WriteLine ("Password must have atleast one numeric character.");
               if (!Regex.IsMatch (input, @"(?=.*[!@#$%^&*()-+)])"))
                  WriteLine ("Password must have atleast one special character[!@#$%^&*()-+].");
               if (input.Contains (' ')) WriteLine ("Password should not have any space characters");
            }
         } else WriteLine ("Please enter a valid string!");
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }
}