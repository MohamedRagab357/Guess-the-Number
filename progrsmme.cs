using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberToGuess, guess, numberOfTries;

            char playAgain;
            do
            {
                numberToGuess = new Random().Next(1, 101);
                numberOfTries = 0;
                guess = 0;
                    Console.WriteLine("Enter your guess: ");

                while (guess != numberToGuess)
                {


                    guess = int.Parse(Console.ReadLine());

                    numberOfTries++;

                    if (guess > numberToGuess)
                    {
                        Console.WriteLine("too high");

                    }
                    else if (guess < numberToGuess)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine("You guessed the number in " + numberOfTries + " tries!");
                    }



                }

                Console.WriteLine("Do you want to play again ? (y/n)");

                playAgain = char.Parse(Console.ReadLine());
                Console.Clear();

            }

            while (playAgain == 'y' || playAgain == 'Y');
        }
    }
}