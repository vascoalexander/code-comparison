for (int row = 1; row < 8; row++)
{
    for (int col = 1; col < 8; col++)
    {
        if ((row == col) || (row + col == 8))
        {
            Console.Write("X");
        }
        else if ((row == 4) || (col == 4))
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
