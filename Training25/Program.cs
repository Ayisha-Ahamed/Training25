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
      do {
         Clear ();
         Write ("Enter string: ");
         var input = ReadLine () ?? "";
         if (!string.IsNullOrEmpty (input) &&
            Regex.IsMatch (input, @"\(\[(.*?)\], \w(, ""(ascending|descending)"")?\)")) {
            input = input[2..^1];
            var str = input.Replace (", ", "").Split (']');
            var arr = str[0];
            if (arr.All (char.IsLetter)) {
               char spl = str[1][0]; string order = str[1][1..];
               WriteLine (SortAndSwap (arr, spl, order == "\"descending\""));
            } else WriteLine ("Invalid format! Please enter string of letters separated by \", \" " +
               "inside the character array");
         } else
            WriteLine ("""
               Invalid Format! Please ensure the input is of the following format:
               ([a, b, c, a, c, b, d], a, "descending")
                         A             S        O
               A - Character array - string of letters separated by comma + space
               S - Special character
               O - Sort order
               """);
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns the sorted array of letters.
   // Letters that match the special character are added at the end, if any.
   static string SortAndSwap (string str, char splChar, bool isDescending) {
      var arr = str.Where (a => a != splChar);
      int sCount = str.Length - arr.Count ();
      // If special character is not an element in the array.
      var sArr = sCount == 0 ? "" : ',' + string.Join (",", Enumerable.Repeat (splChar, sCount));
      if (isDescending) return string.Join (",", arr.OrderDescending ()) + sArr;
      return string.Join (",", arr.Order ()) + sArr;
   }
}