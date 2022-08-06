//Homework for lesson 1, #2
int max = 0;
Console.WriteLine("Enter first number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
int second = int.Parse(Console.ReadLine());
if (first < second)
    {
    max = second;
    }
else
    {
    max = first;
    }
Console.WriteLine($"Max number = {max}");