// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program that prints sorted array by keeping the elements matching special character S
// to the last of the array
// ------------------------------------------------------------------------------------------------
using System.Text.RegularExpressions;
using static System.Console;

namespace Training25;

internal class Program {

   static void Main () {
      const string msg = """
               Ensure input is of the following format:
               ([a, b, c, a, c, b, d], a, "descending")
                         A             S        O
               A - Character array with atleast 2 letters
               S - Special character
               O - Sort order (optional)
               """;
      do {
         Clear ();
         Write ($"{msg}\nEnter string: ");
         var input = ReadLine () ?? "";
         // Regex for validating character array A, special character S and optional sort order.
         Regex regex = new (@"\((\[([a-zA-z],\s?)+[a-zA-z]\]),\s?([a-zA-z])(,\s?""(ascending|descending)"")?\)");
         if (!string.IsNullOrEmpty (input) && regex.IsMatch (input)) {
            input = input[2..^1].Replace (" ", "").Replace (",", "");
            var str = input.Split (']');
            var arr = str[0];
            if (arr.All (char.IsLetter)) {
               char spl = str[1][0]; string order = str[1][1..];
               WriteLine (SortAndSwap (arr, spl, order == "\"descending\""));
            } else WriteLine ("Invalid format! Please refer format for character array(A)!");
         } else WriteLine ("Invalid Format! Please try again!");
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns the sorted array of letters.
   // Letters that match the special character are added at the end, if any.
   static string SortAndSwap (string str, char splChar, bool isDescending) {
      var arr = str.Where (a => a != splChar).ToList ();
      int sCount = str.Length - arr.Count;
      // Check if special character is an element in the array.
      var sArr = sCount == 0 ? "" : ',' + string.Join (",", Enumerable.Repeat (splChar, sCount));
      return string.Join (",", isDescending ? arr.OrderDescending () : arr.Order ()) + sArr;
   }
}