// Exercise 1-3-10
for (int row = 0; row < 7; row++)
{
    for (int col = 0; col < 7; col++)
    {
        if ((row == col) || (row + col == 6))
        {
            Console.Write("X");
        }
        else
        {
            Console.Write("-");
        }
        
    }
    Console.WriteLine("");
}
