// Exercise 1-3-28
for (int row = 0; row < 11; row++)
{
    for (int col = 0; col < 11; col++)
    {
        if (((row == 0) || (row == 11 - 1)) || ((col == 0) || (col == 11 - 1)))
        {
            Console.Write("o");
        }
        else if (row == 5)
        {
            Console.Write("X");
        }
        else if (col == 5)
        {
            Console.Write("X");
        }
        else if ((row + col == 11 - 1) && (row != 0) && (row != 11 - 1))
        {
            Console.Write("i");
        }
        else if (((row == col) && (row != 0)) && (row != 11 - 1))
        {
            Console.Write("i");
        }
        else
        {
            Console.Write(".");
        }
    }
    Console.WriteLine();
}
