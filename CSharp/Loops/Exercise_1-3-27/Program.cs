// Exercise 1-3-27
for (int row = 1; row < 5; row++)
{
    for (int column = 0; column < row; column++)
    {
        Console.Write("*");
    }
    for (int column = 0; column < 2 * (4 - row); column++)
    {
        Console.Write(" ");
    }
    for (int column = 0; column < row; column++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Print the lower half
for (int row = 3; row > 0; row--)
{
    for (int column = 0; column < row; column++)
    {
        Console.Write("*");
    }
    for (int column = 0; column < 2 * (4 - row); column++)
    {
        Console.Write(" ");
    }
    for (int column = 0; column < row; column++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}