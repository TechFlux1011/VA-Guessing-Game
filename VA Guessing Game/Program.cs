Random randomNumber = new Random();
int magicNumber = randomNumber.Next(0, 10);
int userNumber;
int attemptCount = 0;

do
{
    Console.WriteLine("Guess the Magic Number it will be between 1-10: ");
    userNumber = Convert.ToInt32(Console.ReadLine());

    attemptCount++;

    if (userNumber == magicNumber)
    {
        Console.WriteLine("correct");
    }
    else if (userNumber > 10 || userNumber <= 0)
    {
        Console.WriteLine("That is not between 1 through 10");
    }

    else
    {
        Console.WriteLine("Wrong try again");
    }
    if (attemptCount >= 3)
    {
        Console.WriteLine("You've run out of attempts");
        break;
    }
} while (userNumber != magicNumber);



