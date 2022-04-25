Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);

Console.Write("What is  the magic number: ");
string ans = Console.ReadLine();
int num = int.Parse(ans);

if (num == number) {
    Console.WriteLine("You guessed it!");
}

else if (num > number) {
    Console.WriteLine("Lower");
}

else {
    Console.WriteLine("Higher");
}