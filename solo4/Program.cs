using System;
using System.Collections.Generic;

int answer = -1;

List<int> numbers = new List<int>();

while (answer != 0)
{
    Console.WriteLine("Enter a number (enter 0 to quit): ");
    string num = Console.ReadLine();
    answer = int.Parse(num);

    numbers.Add(answer);
}

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($"This is the sum: {sum}");

float average = sum / numbers.Count;
Console.WriteLine($"The avergare is: {average}");

int max = numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine($"This is the max: {max}");