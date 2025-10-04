// Exercise 1-3-24
for (int row = 0; row < 8; row++)
{
    for (int col = 0; col < 8; col++)
    {
        if (((row <= 3) && (col <= 3)) || ((row >= 4) && (col >= 4)))
        {
            Console.Write(".");
        }
        else
        {
            Console.Write("=");
        }
    }
    Console.WriteLine();
}
