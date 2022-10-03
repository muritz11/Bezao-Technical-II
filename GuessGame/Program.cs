using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randNum = random.Next(10);
            int retries = 4;

            string? entry1 = null;
            string? entry2 = null;
            string? entry3 = null;

            Console.WriteLine("===============================");
            Console.WriteLine(" Welcome to the Guessing game ");
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
                        Console.Write("Continue playing? Y/N: ");
                        string answer = Console.ReadLine();
                        Console.WriteLine("--------------------------------");

                        if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                        {
                            randNum = random.Next(10);
                            retries = 5;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    } else if (Int32.Parse(usersGuess) > randNum)
                    {
                        Console.WriteLine("Incorrect!! Number is too large");
                        if(entry1 == null)
                        {
                            entry1 = usersGuess;
                        } else if (entry2 == null)
                        {
                            entry2 = usersGuess;
                        } else if(entry3 == null)
                        {
                            entry3 = usersGuess;
                        }

                        if (entry1 == entry2)
                        {
                            if(entry2 == entry3)
                            {
                                retries--;
                                Console.WriteLine("Number of retries remaining: " + retries);
                            }
                        }


                    } else if (Int32.Parse(usersGuess) < randNum)
                    {
                        Console.WriteLine("Incorrect!! Number is too small");
                        if (entry1 == null)
                        {
                            entry1 = usersGuess;
                        }
                        else if (entry2 == null)
                        {
                            entry2 = usersGuess;
                        }
                        else if (entry3 == null)
                        {
                            entry3 = usersGuess;
                        }

                        if (entry1 == entry2)
                        {
                            if (entry2 == entry3)
                            {
                                retries--;
                                Console.WriteLine("Number of retries remaining: " + retries);
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Sorry, an error occured");
                        Console.WriteLine("--------------------------------");
                        break;
                    }
                } 
                else
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("You've run out of retries");
                    Console.Write("Continue playing? Y/N: ");
                    string answer = Console.ReadLine();
                    Console.WriteLine("--------------------------------");

                    if(answer.ToLower() == "y" || answer.ToLower() == "yes")
                    {
                        randNum = random.Next(10);
                        retries = 5;
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            while (true);

        }
    }
}