Console.Write("Enter first number: ");
string first = Console.ReadLine();
int x = int.Parse(first);

Console.Write("Enter second number: ");
string second = Console.ReadLine();
int y = int.Parse(second);

Console.Write("Enter third number: ");
string third = Console.ReadLine();
int z = int.Parse(third);

int answer = (x + y) * z;
int answer2 = x * y + y * z;

Console.WriteLine($"{answer}, {answer2}");