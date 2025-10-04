int distance;
for (int row = 0; row < 11; row++)
{
    for (int col = 0; col < 11; col++)
    {
        if (row <= 5)
        {
            distance = 5 - row;
        }
        else
        {
            distance = row - 5;
        }
        if ((col == distance) || (col == 11 - distance - 1))
        {
            Console.Write("o");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
