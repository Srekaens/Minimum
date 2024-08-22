static int Min(int a, int b)
{
    if (a < b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine(Min(0, 10));
Console.WriteLine(Min(0, -10));