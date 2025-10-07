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
   static void Main () {
      do {
         Clear ();
         Write ("Enter password: ");
         var input = ReadLine ();
         if (!string.IsNullOrEmpty (input)) {
            (bool, string)[] InvalidConditions = [
               (input.Any (a => a == ' '),"Password must not include space characters"),
               (input.Length < 8,"Password must have atleast 8 characters"),
               (!input.Any (x => (x >= 'a' && x <= 'z')),"Password must have atleast one lower case character"),
               (!input.Any (x => (x >= 'A' && x <= 'Z')),"Password must have atleast one upper case character"),
               (!input.Any (x => (x >= '0' && x <= '9')),"Password must have atleast one numeric character"),
               (!Regex.IsMatch (input, @"(?=.*[!@#$%^&*()-+)])"),
               "Password must have atleast one special character[!@#$%^&*()-+]") ];
            for (int i = 0; i < InvalidConditions.Length; i++)
               if (InvalidConditions[i].Item1) WriteLine (InvalidConditions[i].Item2);
            if (InvalidConditions.All (x => x.Item1 == false)) WriteLine ("Password is strong");
         } else WriteLine ("Please enter a valid string!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }
}