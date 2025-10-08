// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T12: Program to find winner of voting contest.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         var input = ReadLine ();
         if (!string.IsNullOrEmpty (input) && input.ToLower ().All (x => x >= 'a' && x <= 'z'))
            WriteLine (FindPerson (input).person + ", " + FindPerson (input).votes);
         else WriteLine ("Please enter a valid string of characters");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static (char person, int votes) FindPerson (string input) {
      var person = input.ToLower ().GroupBy (x => x)
         .Select (a => new { a.Key, Count = a.Count () })
         .OrderBy (a => a.Count).Last ();
      return (char.ToUpper (person.Key), person.Count);
   }
}