// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T5 branch.
// Program to print multiplication tables from 1-10.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      for (int i = 1; i < 11; i++, WriteLine ())
         for (int j = 1; j < 11; j++)
            WriteLine ($" {i,2} * {j,2} = {i * j,-2}");
   }
}