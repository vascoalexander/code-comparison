// Exercise 1-3-21
for (int row = 0; row < 7; row++)
{
    for (int col = 0; col < 7; col++)
    {
        if (row == col)
        {
            Console.Write("X");
        }
        else if (col == 3)
        {
            Console.Write("X");
        }
        else
        {
            Console.Write("-");
        }
    }
    Console.WriteLine();
}
