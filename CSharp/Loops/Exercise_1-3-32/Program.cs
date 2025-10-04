// Exercise 1-3-32
for (int i = 1; i < 21; i++)
{
    if ((i % 5 == 2) || (i % 5 == 3))
    {
        Console.Write(i + 500 + " ");
    }
    else
    {
        Console.Write(i + " ");
    }
}
