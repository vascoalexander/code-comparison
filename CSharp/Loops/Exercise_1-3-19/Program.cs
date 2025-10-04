// Exercise 1-3-19
for (int j = 0; j < 8; j++)
{
    for (int i = 5; i < 21; i++)
    {
        if (i < 10)
        {
            Console.Write($"{i,2}");
        }
        else
        {
            Console.Write($"{i,3}");
        }
    }
    Console.WriteLine();
}
