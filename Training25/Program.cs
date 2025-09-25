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
   static void Main (string[] args) {
      OutputEncoding = new UnicodeEncoding ();
      string[] whitePcs = { "♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖" },
         blackPcs = { "♜", "♞", "♝", "♛", "♚", "♝", "♞", "♜" };
      string whitePawn = "♙", blackPawn = "♟";
      WriteLine ("┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓");
      PrintChars (blackPcs);
      WriteLine ("\n┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
      PrintPcs (blackPawn);
      for (int i = 4; i > 0; i--) PrintPcs ();
      PrintPcs (whitePawn);
      PrintChars (whitePcs);
      WriteLine ("\n┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛");
   }

   static void PrintPcs (string piece = " ") {
      Write ("┃");
      for (int i = 0; i < 8; i++) Write ($" {piece} ┃");
      WriteLine ("\n┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫");
   }

   static void PrintChars (string[] chars) {
      Write ("┃");
      for (int i = 0; i < 8; i++) Write ($" {chars[i]} ┃");
   }
}