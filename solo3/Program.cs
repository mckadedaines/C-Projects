Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);

int guess = -1;

while (guess != number) 
{
    Console.Write("What is the magic number: ");
    string ans = Console.ReadLine();
    guess = int.Parse(ans);

    if (guess < number) {
        Console.WriteLine("Higher");
    }

    else if (guess > number) {
        Console.WriteLine("Lower");
    }

    else {
        Console.WriteLine("Congrats you passed!");
    }
}
