// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T4 branch.
// Program to print chess board.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      OutputEncoding = new UnicodeEncoding ();
      char[] whitePcs = ['♖', '♘', '♗', '♕', '♔', '♗', '♘', '♖'],
      blackPcs = ['♜', '♞', '♝', '♛', '♚', '♝', '♞', '♜'];
      char whitePawn = '♙', blackPawn = '♟';
      for (int i = 0; i < 17; i++) switch (i) {
            case 0: WriteLine ("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓"); break;
            case 1: PrintChars (blackPcs); break;
            case 3: PrintChars ([.. Enumerable.Repeat (blackPawn, 8)]); break;
            case 5 or 7 or 9 or 11: PrintChars ([.. Enumerable.Repeat (' ', 8)]); break;
            case 13: PrintChars ([.. Enumerable.Repeat (whitePawn, 8)]); break;
            case 15: PrintChars (whitePcs); break;
            case 16: WriteLine ("\n┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛"); break;
            default: WriteLine ("\n┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫"); break;
         }
   }

   static void PrintChars (char[] pieces) {
      Write ("┃");
      for (int i = 0; i < 8; i++) Write ($" {pieces[i]} ┃");
   }
}