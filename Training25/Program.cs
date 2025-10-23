// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// T12: Program to find the winner with the most votes.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         var input = ReadLine ();
         if (!string.IsNullOrEmpty (input) && input.All (char.IsLetter)) {
            (char person, int votes) = FindWinner (input);
            WriteLine ($"{char.ToUpper (person)}, {votes}");
         } else WriteLine ("Please enter a valid string of characters");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   static (char Person, int Vote) FindWinner (string input) => input.ToLower ().GroupBy (x => x)
       .Select (a => (a.Key, a.Count ())).MaxBy (a => a.Item2);
}