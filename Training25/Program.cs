// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T2 branch.
// Program to convert input number to words and roman numerals.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Clear ();
         Write ("Enter input: ");
         if (int.TryParse (ReadLine (), out int output) && output >= 0) {
            WriteLine ("Choose option:\n\tA) Convert number to words\n\tB) Convert number to roman numerals");
            switch (ReadKey (true).Key) {
               case ConsoleKey.A: WriteLine (ConvertToWords (output)); break;
               case ConsoleKey.B: WriteLine (ConvertToRoman (output)); break;
            }
         } else WriteLine ("Please enter a positive integer!");
         WriteLine ("\nPress 'Y' to continue");
      } while (ReadKey (true).Key == ConsoleKey.Y);
   }

   /// <summary>Converts input number to words</summary>
   public static string ConvertToWords (int num) {
      if (num == 0) return "Zero";
      string[] ones = ["One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"],
         teens = [ "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
         "Seventeen", "Eighteen", "Nineteen" ],
         tens = [ "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty",
         "Ninety" ],
         baseVals = ["", "Thousand", "Mil1ion", "Billion"];
      string output = "";
      for (int baseVal = 1000000000, indexPos = 3; baseVal >= 1 && indexPos >= 0; baseVal /= 1000, indexPos--) {
         int quotient = num / baseVal;
         // Group number into hundreds
         while (quotient > 0)
            switch (quotient) {
               case >= 100:
                  output += ones[quotient / 100 - 1] + " Hundred " + (num % 100 == 0 ? "" : "and ");
                  quotient %= 100; break;
               case >= 1 and < 10:
                  output += ones[quotient - 1];
                  quotient = 0; break;
               case >= 11 and <= 19:
                  output += teens[quotient - 11];
                  quotient = 0; break;
               default:
                  output += tens[quotient / 10 - 1] + " ";
                  quotient %= 10; break;
            }
         if (num / baseVal > 0) output += " " + baseVals[indexPos] + " ";
         num %= baseVal;
      }
      return output;
   }

   /// <summary>Converts input into roman numeral</summary>
   public static string ConvertToRoman (int num) {
      if (num < 1 || num > 3999) return "Number is out of range for conversion (1 - 3999)";
      (int, string)[] numerals = [ (1000, "M"), (900, "CM"), (500, "D"), (400,"CD"), (100,"C"),
            (90,"XC"), (50,"L"), (40,"XL"), (10,"X"), (9,"IX"), (5,"V"), (4,"IV"), (1,"I") ];
      string output = "";
      for (int i = 0; num >= 0 && i < numerals.Length; i++)
         while (num >= numerals[i].Item1) {
            output += numerals[i].Item2;
            num -= numerals[i].Item1;
         }
      return output;
   }
}