// Exercise 1-3-29
for (int row = 0; row < 7; row++)
{
    for (int col = 0; col < 7; col++)
    {
        if ((row == col) || (row + col == 6))
        {
            Console.Write("*");
        }
        else if ((col == 0) || (col == 6))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
