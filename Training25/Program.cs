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
            (bool isFailed, string msg)[] InvalidConditions = [
               ( input.Any (char.IsWhiteSpace), "Password must not include space characters" ),
               ( input.Length < 8, "Password must have atleast 8 characters" ),
               ( !input.Any (char.IsLower), "Password must have atleast one lower case character" ),
               ( !input.Any (char.IsUpper), "Password must have atleast one upper case character" ),
               ( !input.Any (char.IsNumber), "Password must have atleast one numeric character" ),
               ( !Regex.IsMatch (input, @"(?=.*[!@#$%^&*()-+)])" ),
               "Password must have atleast one special character[!@#$%^&*()-+]" ) ];
            // Print message if the respective condition fails
            for (int i = 0; i < InvalidConditions.Length; i++)
               if (InvalidConditions[i].isFailed) WriteLine (InvalidConditions[i].msg);
            if (InvalidConditions.All (x => !x.isFailed)) WriteLine ("Password is strong");
         } else WriteLine ("Please enter a non-empty string!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }
}