Console.WriteLine("Введите два числа a и b");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"a={a};b={b}->max={a}");
}
else
{
    if (a == b)
    {
        Console.WriteLine($"a=b={a}");
    }
    else
    {
        Console.WriteLine($"a={a};b={b}->max={b}");
    }
}


