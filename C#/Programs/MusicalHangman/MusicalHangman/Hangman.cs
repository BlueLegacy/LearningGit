using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Hangman
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Hangman!");
            Console.ReadLine();
            string[] listwords = new string[10];
            listwords[0] = "treble";
            listwords[1] = "bass";
            listwords[2] = "percussion";
            listwords[3] = "saxophone";
            listwords[4] = "horn";
            listwords[5] = "clarinet";
            listwords[6] = "flute";
            listwords[7] = "trumpet";
            listwords[8] = "trombone";
            listwords[9] = "tuba";

            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.WriteLine("Please enter your guess: ");

            for (int p=0; p<mysteryWord.Length; p++)
                playerGuess[p] = '*';

            while (true)
            {
                 playerGuess = (char) Console.ReadLine();
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess = mysteryWord[j])
                        guess[j] = playerGuess;

                }
                Console.WriteLine(guess);
            }
        }
    }
}
