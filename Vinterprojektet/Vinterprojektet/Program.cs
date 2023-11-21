using System;

string name = "Majkel";
string favoriteSport = "Fotboll";
string petName = "Kahpe";

Console.WriteLine("Majkel");
name = Console.ReadLine();

Console.WriteLine("Fotboll");
favoriteSport = Console.ReadLine();

Console.WriteLine("Kahpe");
petName = Console.ReadLine();

//------------------------------------------------------------------------------

Console.WriteLine($"Hördu Majkel, jag har hört att du är jättedålig på Fotboll.");
Console.WriteLine($"Du är så dålig att till och med kahpe skrattar åt dig!");

Console.WriteLine("Tryck på ENTER för att avsluta.");
Console.ReadLine();