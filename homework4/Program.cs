int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b & a > c)
{
    Console.WriteLine($"{a},{b},{c}->{a}");
}
if (b > a & b > c)
{
    Console.WriteLine($"{a},{b},{c}->{b}");
}
if (c > b & c > a)
{
    Console.WriteLine($"{a},{b},{c}->{c}");
}
else
{
    if (a == b & a == c) // Если все равны
    {
    Console.WriteLine($"{a},{b},{c}->равны");
    }
    else // Если равны два числа
    {
        if (a == b & a > c)
        {
            Console.WriteLine($"{a},{b},{c}->{a}");
        }
        else
        {
            Console.WriteLine($"{a},{b},{c}->{c}");
        }
        if (a == c & a > b)
        {
            Console.WriteLine($"{a},{b},{c}->{a}");
        }
        else
        {
            Console.WriteLine($"{a},{b},{c}->{b}");
        }
        if (c == b & c > a)
        {
            Console.WriteLine($"{a},{b},{c}->{c}");
        }
        else
        {
            Console.WriteLine($"{a},{b},{c}->{a}");
        }
    }
}


