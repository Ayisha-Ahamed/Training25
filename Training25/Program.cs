// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program that prints sorted array by keeping the elements matching special character S
// to the last of the array
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter array of letters: ");
         var (str, isValid) = GetArray ();
         if (isValid) {
            Write ("Enter special character: ");
            var splChar = GetSplChar ();
            WriteLine ("\nPress 'D' to sort in descending order");
            WriteLine (SortAndSwap (str, splChar, ReadKey (true).Key == ConsoleKey.D));
         } else WriteLine (str);
         Write ("Press 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   // Returns the special character to be added at the end of the string.
   static char GetSplChar () {
      var splChar = ReadKey ().KeyChar;
      while (!char.IsLetter (splChar)) {
         WriteLine ("\nPlease enter a valid character (A-Z).Enter special character: ");
         splChar = ReadKey ().KeyChar;
      }
      return splChar;
   }

   // Returns the error message (or) extracted string from comma separated input.
   static (string str, bool isValid) GetArray () {
      var array = ReadLine ();
      if (string.IsNullOrEmpty (array)) return ("Input cannot be empty!", false);
      string str = "";
      for (int i = 0, len = array.Length; i < len; i++) {
         bool isEven = (i & 1) == 0;
         // Check if even positions and odd positions of the array
         // are filled with letters and ',' respectively.
         if ((isEven && !char.IsLetter (array[i]) || (!isEven && array[i] != ',')))
            return ("Invalid format! Please enter comma seperated string of letters", false);
         else if (isEven) str += array[i];
      }
      return (str, true);
   }

   // Returns the sorted array of letters.
   // Letters that match the special character are added at the end, if any.
   static string SortAndSwap (string str, char splChar, bool isDescending) {
      var arr = str.Where (a => a != splChar);
      int sCount = str.Length - arr.Count ();
      var sArr = (arr.Count () == str.Length) ? "" :
         +',' + string.Join (",", new string (splChar, sCount));
      if (isDescending) return string.Join (",", arr.OrderDescending ()) + sArr;
      return string.Join (",", arr.Order ()) + sArr;
   }
}