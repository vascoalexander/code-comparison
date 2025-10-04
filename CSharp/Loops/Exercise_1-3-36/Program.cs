// Exercise 1-3-36
for (int row = 0; row < 7; row++)
{
    for (int col = 0; col < 9; col++)
    {
        if ((row % 2 == 0) && (col % 2 == 0))
        {
            Console.Write("X");
        }
        else if ((row % 2 != 0) && (col % 2 != 0))
        {
            Console.Write("X");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
