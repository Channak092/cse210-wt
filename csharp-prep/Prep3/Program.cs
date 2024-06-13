using System;

string userGuess;
int number;
int guess;

Random randomGenerator = new Random();
number = randomGenerator.Next(1, 100);

Console.Write("Guess a number between 1 and 100: ");
userGuess = Console.ReadLine();
guess = int.Parse(userGuess);

while (guess != number)
{
    if (guess > number)
    {
        Console.WriteLine("Number to Lower");
        Console.Write("What is your next guess? ");
        userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);
    }
    else if (guess < number)
    {
        Console.WriteLine("Number to Higher");
        Console.Write("What is your next guess? ");
        userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);
    }
}
Console.WriteLine("Congralulation!! You guessed it!!");
