// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// T4: Program to print chess board.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      OutputEncoding = new UnicodeEncoding ();
      WriteLine ("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
      PrintRow ("♜♞♝♛♚♝♞♜");
      char[] pawns = { '♟', '♙' };
      for (int i = 0; i < 13; i++)
         // In even iterations print line separator.
         if ((i & 1) == 0) WriteLine ("\n┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
         else {
            char rChar = ' ';
            // Print black or white pawns for i = 1 or i = 11 respectively.
            if (i % 10 == 1) rChar = pawns[0 + (i / 10)];
            PrintRow (string.Concat (Enumerable.Repeat (rChar, 8)));
         }
      PrintRow ("♖♘♗♕♔♗♘♖");
      WriteLine ("\n┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛");
   }

   static void PrintRow (string pieces) =>
      Write ("┃ " + string.Join (" ┃ ", pieces.ToCharArray ()) + " ┃");
}