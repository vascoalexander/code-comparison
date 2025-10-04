// Exercise 1-3-23
for (int row = 0; row < 8; row++)
{
    for (int col = 0; col < 8; col++)
    {
        if (row <= 3 && col <= 3)
        {
            Console.Write(".");
        }
        else
        {
            Console.Write("=");
        }
    }
    Console.WriteLine("");
}
