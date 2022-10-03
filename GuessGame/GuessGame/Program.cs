using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  0. use the random lib to get a random integer between 0-100
                1. You get the input of the user
                2. You create a variable that is initially 0. This is the number of tries\
                3. You run a while loop that continuses till guess == random
                4. Inside the while loop theres a condition.. If the guess is > than the random, tell the person it's greater
                    if the guess is less than the random, tell the person it's less else declare the person winner and break the loop.
                5. N:B at the start of the while loop, increment the number of tries by 1.. 
             */

            Random random = new Random();
            int randNum = random.Next(10);
            int retries = 5;

            Console.WriteLine("===============================");
            Console.WriteLine("  Welcome to the Guessing game ");
            Console.WriteLine("===============================");

            do
            {
                Console.WriteLine("--------------------------------");
                Console.Write("Try guessing a number from 1 - 10: ");
                string usersGuess = Console.ReadLine();
                Console.WriteLine("--------------------------------");
                if (retries > 1)
                {
                    if (!usersGuess.Any(x => !char.IsLetter(x)))
                    {
                        if (usersGuess.ToLower() == "exit")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            continue;
                        }
                    }

                    if (Int32.Parse(usersGuess) == randNum)
                    {
                        Console.WriteLine("Correct, you guessed right!");
                        break;
                    } else if (Int32.Parse(usersGuess) > randNum)
                    {
                        Console.WriteLine("Incorrect!! Number is too large");
                        retries--;
                        Console.WriteLine("Number of retries remaining: " + retries);
                    } else if (Int32.Parse(usersGuess) < randNum)
                    {
                        Console.WriteLine("Incorrect!! Number is too small");
                        retries--;
                        Console.WriteLine("Number of retries remaining: " + retries);
                    } else
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Sorry, an error occured");
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                } else
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("You've run out of retries");
                    Console.WriteLine("--------------------------------");
                    break ;
                }
            }
            while (true);


        }
    }
}