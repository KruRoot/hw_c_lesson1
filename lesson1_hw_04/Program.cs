//Homework for lesson 1, #4
int max = 0;
Console.WriteLine("Enter first number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number");
int third = int.Parse(Console.ReadLine());
if (first < second)
    {
    max = second;
    }
else
    {
    max = first;
    }
if (max < third)
    {
    max = third;
    }
else
    {
    }
Console.WriteLine($"Max number = {max}");