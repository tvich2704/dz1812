int n = int.Parse(Console.ReadLine());
int count = 1;
Console.Write($"{n}->");
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count += 1;
}

