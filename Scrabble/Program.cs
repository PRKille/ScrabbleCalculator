using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
    Console.WriteLine("Welcome to Scrabble!");
    Console.WriteLine("Please enter a word below:");
    string userResponse = Console.ReadLine();
    Console.WriteLine(Words.WordScore(userResponse));
    }
  }
}