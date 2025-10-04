// Exercise 1-3-26
for (int row = 1; row < 8; row++)
{
    for (int col = 1; col < 8; col++)
    {
        if (row < 4)
        {
            if ((col == row) || (col + row == 8))
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("-");
            }
        }
        else
        {
            if ((col >= 4 - (row - 4)) && (col < 4 + ((row - 4) + 1)))
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("-");
            }
        }
    }
    Console.WriteLine();
}
