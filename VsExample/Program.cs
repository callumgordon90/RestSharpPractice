// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

#pragma warning disable CS7022 // The entry point of the program is global code; ignoring entry point
#pragma warning disable CS8321 // Local function is declared but never used
static void Main(string[] args)
{
    // Set up Console UI (CUI)
    Console.Title = "My Rocking App";
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine("***********************************");
    Console.WriteLine("**** Welcome to My Rocking App ****");
    Console.WriteLine("***********************************");
    Console.BackgroundColor= ConsoleColor.Black;

    //Wait for Enter key to be pressed.
    Console.ReadLine();
}
#pragma warning restore CS8321 // Local function is declared but never used
#pragma warning restore CS7022 // The entry point of the program is global code; ignoring entry point
