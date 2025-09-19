// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) {
      do {
         Console.Clear ();
         Console.Write ("Input: ");
         try {
            var input = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("HEX: " + Convert.ToString (input, 16).ToUpper ());
            Console.WriteLine ("Binary: " + Convert.ToString (input, 2));
         } catch (Exception ex) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine ("Error: " + ex.Message);
            Console.ResetColor ();
         }
         Console.WriteLine ("Press 'Y' to continue");
      } while (Console.ReadKey (true).Key == ConsoleKey.Y);
   }
}