for (int num = 1; num <= 100; num++)
{
    Console.Write(num);
    bool divisibleByThree = (num % 3 == 0);
    bool divisibleByFive = (num % 5 == 0);
    if (divisibleByThree || divisibleByFive)
        Console.Write(" - ");
    if (divisibleByThree)
        Console.Write("Fizz");
    if (divisibleByFive)
        Console.Write("Buzz");
    Console.Write($"\n");
}